using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BN.Infrastrure.EFCore.Migrations
{
    public partial class Refactoring : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "Users",
                newName: "Creationdate");

            migrationBuilder.RenameColumn(
                name: "User_Id",
                table: "Users",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "NewsCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CreationDate",
                table: "News",
                newName: "Creationdate");

            migrationBuilder.RenameColumn(
                name: "NewsId",
                table: "News",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Comment_Id",
                table: "Comment",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "Creationdate",
                table: "NewsCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creationdate",
                table: "NewsCategories");

            migrationBuilder.RenameColumn(
                name: "Creationdate",
                table: "Users",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "User_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NewsCategories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Creationdate",
                table: "News",
                newName: "CreationDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "News",
                newName: "NewsId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Comment",
                newName: "Comment_Id");
        }
    }
}
