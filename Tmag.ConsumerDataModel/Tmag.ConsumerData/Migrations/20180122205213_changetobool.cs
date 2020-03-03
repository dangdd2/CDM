using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class changetobool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "is_minor_adjustment",
                table: "club_shaft_lengths",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000,
                defaultValue:false,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "is_minor_adjustment",
                table: "club_shaft_lengths",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
