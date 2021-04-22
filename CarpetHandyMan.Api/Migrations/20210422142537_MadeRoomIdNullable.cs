using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpetHandyMan.Api.Migrations
{
    public partial class MadeRoomIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Closets_Rooms_RoomId",
                table: "Closets");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Closets",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Closets_Rooms_RoomId",
                table: "Closets",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Closets_Rooms_RoomId",
                table: "Closets");

            migrationBuilder.AlterColumn<Guid>(
                name: "RoomId",
                table: "Closets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Closets_Rooms_RoomId",
                table: "Closets",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
