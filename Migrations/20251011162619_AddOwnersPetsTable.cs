using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnersPetsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OwnersPets",
                table: "OwnersPets");

            migrationBuilder.RenameTable(
                name: "OwnersPets",
                newName: "owners_pets");

            migrationBuilder.AddColumn<int>(
                name: "owner_id",
                table: "owners_pets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "pet_id",
                table: "owners_pets",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_owners_pets_owner_id",
                table: "owners_pets",
                column: "owner_id");

            migrationBuilder.CreateIndex(
                name: "IX_owners_pets_pet_id",
                table: "owners_pets",
                column: "pet_id");

            migrationBuilder.AddForeignKey(
                name: "FK_owners_pets_Pets_pet_id",
                table: "owners_pets",
                column: "pet_id",
                principalTable: "Pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_owners_pets_owners_owner_id",
                table: "owners_pets",
                column: "owner_id",
                principalTable: "owners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_owners_pets_Pets_pet_id",
                table: "owners_pets");

            migrationBuilder.DropForeignKey(
                name: "FK_owners_pets_owners_owner_id",
                table: "owners_pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets");

            migrationBuilder.DropIndex(
                name: "IX_owners_pets_owner_id",
                table: "owners_pets");

            migrationBuilder.DropIndex(
                name: "IX_owners_pets_pet_id",
                table: "owners_pets");

            migrationBuilder.DropColumn(
                name: "owner_id",
                table: "owners_pets");

            migrationBuilder.DropColumn(
                name: "pet_id",
                table: "owners_pets");

            migrationBuilder.RenameTable(
                name: "owners_pets",
                newName: "OwnersPets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OwnersPets",
                table: "OwnersPets",
                column: "id");
        }
    }
}
