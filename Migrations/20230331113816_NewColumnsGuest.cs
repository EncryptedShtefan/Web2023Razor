using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web2023Razor.Migrations
{
    public partial class NewColumnsGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Guest",
                newName: "BirthDate");

            migrationBuilder.AddColumn<string>(
                name: "ApartmentNumber",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateArrive",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDepart",
                table: "Guest",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HealthProgName",
                table: "Guest",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApartmentNumber",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "DateArrive",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "DateDepart",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "HealthProgName",
                table: "Guest");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Guest",
                newName: "birthDate");
        }
    }
}
