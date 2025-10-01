using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class userV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "name");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "update_at",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "is_active",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "update_at",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Users",
                newName: "Name");
        }
    }
}
