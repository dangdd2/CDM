using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class OptInChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_consumer_opt_in_consumer_emails_ConsumerEmailId",
                table: "consumer_opt_in");
            

            migrationBuilder.DropColumn(
                name: "ConsumerEmailId",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "consumer_email_id",
                table: "consumer_opt_in");

            migrationBuilder.AddColumn<bool>(
                name: "allowed",
                table: "consumer_opt_in",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "consumer_profile_id",
                table: "consumer_opt_in",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<bool>(
                name: "emailOnly",
                table: "consumer_opt_in",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_consumer_opt_in_consumer_profile_id",
                table: "consumer_opt_in",
                column: "consumer_profile_id");

            migrationBuilder.AddForeignKey(
                name: "FK_consumer_opt_in_consumer_profile_consumer_profile_id",
                table: "consumer_opt_in",
                column: "consumer_profile_id",
                principalTable: "consumer_profile",
                principalColumn: "consumer_profile_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_consumer_opt_in_consumer_profile_consumer_profile_id",
                table: "consumer_opt_in");

            migrationBuilder.DropIndex(
                name: "IX_consumer_opt_in_consumer_profile_id",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "allowed",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "consumer_profile_id",
                table: "consumer_opt_in");

            migrationBuilder.DropColumn(
                name: "emailOnly",
                table: "consumer_opt_in");

            migrationBuilder.AddColumn<Guid>(
                name: "ConsumerEmailId",
                table: "consumer_opt_in",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "consumer_email_id",
                table: "consumer_opt_in",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_consumer_opt_in_ConsumerEmailId",
                table: "consumer_opt_in",
                column: "ConsumerEmailId");

            migrationBuilder.AddForeignKey(
                name: "FK_consumer_opt_in_consumer_emails_ConsumerEmailId",
                table: "consumer_opt_in",
                column: "ConsumerEmailId",
                principalTable: "consumer_emails",
                principalColumn: "consumer_email_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
