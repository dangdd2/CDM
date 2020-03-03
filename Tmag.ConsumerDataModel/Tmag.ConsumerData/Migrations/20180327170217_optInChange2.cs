using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class optInChange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_consumer_opt_in_consumer_profile_id",
                table: "consumer_opt_in");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_opt_in_consumer_profile_id_key",
                table: "consumer_opt_in",
                columns: new[] { "consumer_profile_id", "key" },
                unique: true,
                filter: "[key] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_consumer_opt_in_consumer_profile_id_key",
                table: "consumer_opt_in");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_opt_in_consumer_profile_id",
                table: "consumer_opt_in",
                column: "consumer_profile_id");
        }
    }
}
