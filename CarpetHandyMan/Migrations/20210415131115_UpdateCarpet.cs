using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpetHandyMan.Api.Migrations
{
    public partial class UpdateCarpet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Carpet",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Carpet");
        }
    }
}
