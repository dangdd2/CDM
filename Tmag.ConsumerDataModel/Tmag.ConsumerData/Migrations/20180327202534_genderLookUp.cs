using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class genderLookUp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    gender_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modified_by = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    gender = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.gender_id);
                });

            //migrationBuilder.CreateIndex(
            //    name: "IX_consumers_gender_id",
            //    table: "consumers",
            //    column: "gender_id");

            migrationBuilder.AddForeignKey(
                name: "FK_consumers_gender_gender_id",
                table: "consumers",
                column: "gender_id",
                principalTable: "gender",
                principalColumn: "gender_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_consumers_gender_gender_id",
                table: "consumers");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropIndex(
                name: "IX_consumers_gender_id",
                table: "consumers");
        }
    }
}
