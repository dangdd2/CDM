using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class FixForGvc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image_one",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_three",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_two",
                table: "model");

            migrationBuilder.AlterColumn<string>(
                name: "third_party_id",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_large",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_reg",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_small",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_thumb",
                table: "model",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_brands_club_category_id",
                table: "brands",
                column: "club_category_id");

            migrationBuilder.AddForeignKey(
                name: "FK_brands_club_categories_club_category_id",
                table: "brands",
                column: "club_category_id",
                principalTable: "club_categories",
                principalColumn: "club_category_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_brands_club_categories_club_category_id",
                table: "brands");

            migrationBuilder.DropIndex(
                name: "IX_brands_club_category_id",
                table: "brands");

            migrationBuilder.DropColumn(
                name: "image_large",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_reg",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_small",
                table: "model");

            migrationBuilder.DropColumn(
                name: "image_thumb",
                table: "model");

            migrationBuilder.AlterColumn<Guid>(
                name: "third_party_id",
                table: "model",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_one",
                table: "model",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_three",
                table: "model",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "image_two",
                table: "model",
                maxLength: 2000,
                nullable: true);
        }
    }
}
