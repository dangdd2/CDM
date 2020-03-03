using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class RemovedRestrictionOnBag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_brands_brand_id",
                table: "whats_in_the_bag");

            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_club_categories_category_id",
                table: "whats_in_the_bag");

            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_model_model_id",
                table: "whats_in_the_bag");

            migrationBuilder.AlterColumn<Guid>(
                name: "model_id",
                table: "whats_in_the_bag",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "whats_in_the_bag",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "brand_id",
                table: "whats_in_the_bag",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_brands_brand_id",
                table: "whats_in_the_bag",
                column: "brand_id",
                principalTable: "brands",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_club_categories_category_id",
                table: "whats_in_the_bag",
                column: "category_id",
                principalTable: "club_categories",
                principalColumn: "club_category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_model_model_id",
                table: "whats_in_the_bag",
                column: "model_id",
                principalTable: "model",
                principalColumn: "model_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_brands_brand_id",
                table: "whats_in_the_bag");

            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_club_categories_category_id",
                table: "whats_in_the_bag");

            migrationBuilder.DropForeignKey(
                name: "FK_whats_in_the_bag_model_model_id",
                table: "whats_in_the_bag");

            migrationBuilder.AlterColumn<Guid>(
                name: "model_id",
                table: "whats_in_the_bag",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "category_id",
                table: "whats_in_the_bag",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "brand_id",
                table: "whats_in_the_bag",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_brands_brand_id",
                table: "whats_in_the_bag",
                column: "brand_id",
                principalTable: "brands",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_club_categories_category_id",
                table: "whats_in_the_bag",
                column: "category_id",
                principalTable: "club_categories",
                principalColumn: "club_category_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_whats_in_the_bag_model_model_id",
                table: "whats_in_the_bag",
                column: "model_id",
                principalTable: "model",
                principalColumn: "model_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
