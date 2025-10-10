using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class modelsComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "name",
                table: "owners",
                newName: "phone");

            migrationBuilder.AddColumn<string>(
                name: "bred",
                table: "Pets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Pets",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "sexo",
                table: "Pets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "owners",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "first_name",
                table: "owners",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "last_name",
                table: "owners",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bred",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "sexo",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "email",
                table: "owners");

            migrationBuilder.DropColumn(
                name: "first_name",
                table: "owners");

            migrationBuilder.DropColumn(
                name: "last_name",
                table: "owners");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "owners",
                newName: "name");
        }
    }
}
