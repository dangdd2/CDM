using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class AddedConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_consumer_profile_region_id",
                table: "consumer_profile");

            migrationBuilder.CreateIndex(
                name: "IX_consumers_primary_email",
                table: "consumers",
                column: "primary_email",
                unique: true,
                filter: "[primary_email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_region_id",
                table: "consumer_profile",
                column: "region_id",
                unique: false);

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_region_id_consumer_id",
                table: "consumer_profile",
                columns: new[] { "region_id", "consumer_id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_consumers_primary_email",
                table: "consumers");

            migrationBuilder.DropIndex(
                name: "IX_consumer_profile_region_id",
                table: "consumer_profile");

            migrationBuilder.DropIndex(
                name: "IX_consumer_profile_region_id_consumer_id",
                table: "consumer_profile");

            migrationBuilder.CreateIndex(
                name: "IX_consumer_profile_region_id",
                table: "consumer_profile",
                column: "region_id");
        }
    }
}
