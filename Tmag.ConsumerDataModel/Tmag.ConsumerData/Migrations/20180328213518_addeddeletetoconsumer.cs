using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class addeddeletetoconsumer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                   name: "deleted",
                   table: "whats_in_the_bag");
            migrationBuilder.AddColumn<DateTime>(
                name: "deleted",
                table: "whats_in_the_bag",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "consumers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "consumers");

            migrationBuilder.AlterColumn<bool>(
                name: "deleted",
                table: "whats_in_the_bag",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
