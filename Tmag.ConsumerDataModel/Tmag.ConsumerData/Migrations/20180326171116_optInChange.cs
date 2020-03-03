using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class optInChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "allowed",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "taylormade_brand",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "emailOnly",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "my_fitting_exp",
                table: "consumer_opt_in");

            migrationBuilder.AddColumn<string>(
                name: "key",
                table: "consumer_opt_in",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "value",
                table: "consumer_opt_in",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "key",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "value",
                table: "consumer_opt_in");

            migrationBuilder.AddColumn<bool>(
                name: "allowed",
                table: "consumer_opt_in",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "taylormade_brand",
                table: "consumer_opt_in",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "emailOnly",
                table: "consumer_opt_in",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "my_fitting_exp",
                table: "consumer_opt_in",
                nullable: false,
                defaultValue: false);
        }
    }
}
