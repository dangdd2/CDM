using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class Images : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Deleted",
                table: "model",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_one",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_three",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_two",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "third_party_id",
                table: "model",
                type: "uniqueidentifier",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_one",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_three",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_two",
                table: "model");

            migrationBuilder.DropColumn(
                name: "third_party_id",
                table: "model");
        }
    }
}
