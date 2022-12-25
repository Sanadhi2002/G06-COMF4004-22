using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.UniversityDb
{
    /// <inheritdoc />
    public partial class AddFacultiesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisteredUniversities",
                table: "RegisteredUniversities");

            migrationBuilder.RenameTable(
                name: "RegisteredUniversities",
                newName: "Universities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universities",
                table: "Universities",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universities",
                table: "Universities");

            migrationBuilder.RenameTable(
                name: "Universities",
                newName: "RegisteredUniversities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisteredUniversities",
                table: "RegisteredUniversities",
                column: "Name");
        }
    }
}
