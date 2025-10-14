using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class AddOwnersPetsTableV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_Pets_pet_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_owners_pets_Pets_pet_id",
                table: "owners_pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets");

            migrationBuilder.DropIndex(
                name: "IX_owners_pets_owner_id",
                table: "owners_pets");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "pets");

            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "pets",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "bred",
                table: "pets",
                newName: "breed");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "owners_pets",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_pets",
                table: "pets",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets",
                columns: new[] { "owner_id", "pet_id" });

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_pets_pet_id",
                table: "appointments",
                column: "pet_id",
                principalTable: "pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_owners_pets_pets_pet_id",
                table: "owners_pets",
                column: "pet_id",
                principalTable: "pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_appointments_pets_pet_id",
                table: "appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_owners_pets_pets_pet_id",
                table: "owners_pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_pets",
                table: "pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets");

            migrationBuilder.RenameTable(
                name: "pets",
                newName: "Pets");

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "Pets",
                newName: "sexo");

            migrationBuilder.RenameColumn(
                name: "breed",
                table: "Pets",
                newName: "bred");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "owners_pets",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_owners_pets",
                table: "owners_pets",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_owners_pets_owner_id",
                table: "owners_pets",
                column: "owner_id");

            migrationBuilder.AddForeignKey(
                name: "FK_appointments_Pets_pet_id",
                table: "appointments",
                column: "pet_id",
                principalTable: "Pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_owners_pets_Pets_pet_id",
                table: "owners_pets",
                column: "pet_id",
                principalTable: "Pets",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
