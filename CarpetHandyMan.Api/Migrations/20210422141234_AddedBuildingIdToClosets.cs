using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpetHandyMan.Api.Migrations
{
    public partial class AddedBuildingIdToClosets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BuildingId",
                table: "Closets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuildingId",
                table: "Closets");
        }
    }
}
