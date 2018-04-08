using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace asp_core_lmyc.Data.Migrations
{
    public partial class addinguserIdfieldtoapplicationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Reservation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Reservation");
        }
    }
}
