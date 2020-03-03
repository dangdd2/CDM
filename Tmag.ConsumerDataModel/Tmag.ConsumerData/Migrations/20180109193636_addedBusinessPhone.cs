using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Tmag.ConsumerData.Migrations
{
    public partial class addedBusinessPhone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<string>(
            //    name: "PhoneBusiness",
            //    table: "consumer_profile",
            //    type: "nvarchar(2000)",
            //    maxLength: 2000,
            //    nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "PhoneBusiness",
            //    table: "consumer_profile");
        }
    }
}
