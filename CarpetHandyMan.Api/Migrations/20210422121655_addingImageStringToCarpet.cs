using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpetHandyMan.Api.Migrations
{
    public partial class addingImageStringToCarpet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Carpet",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Carpet");
        }
    }
}
