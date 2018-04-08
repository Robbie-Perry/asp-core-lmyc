using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace asp_core_lmyc.Data.Migrations
{
    public partial class removinguseridandaddingusernamereservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reservation",
                newName: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Reservation",
                newName: "UserId");
        }
    }
}
