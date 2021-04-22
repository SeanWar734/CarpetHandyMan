using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpetHandyMan.Api.Migrations
{
    public partial class AddedCarpetToClosets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CarpetId",
                table: "Closets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "CarpetPrice",
                table: "Closets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarpetId",
                table: "Closets");

            migrationBuilder.DropColumn(
                name: "CarpetPrice",
                table: "Closets");
        }
    }
}
