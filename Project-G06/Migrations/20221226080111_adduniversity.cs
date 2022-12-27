using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.UniversityDb
{
    /// <inheritdoc />
    public partial class adduniversity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Universities",
                table: "Universities");

            migrationBuilder.RenameTable(
                name: "Universities",
                newName: "RegisteredUniversities");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "RegisteredUniversities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegisteredUniversities",
                table: "RegisteredUniversities",
                column: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RegisteredUniversities",
                table: "RegisteredUniversities");

            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "RegisteredUniversities");

            migrationBuilder.RenameTable(
                name: "RegisteredUniversities",
                newName: "Universities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Universities",
                table: "Universities",
                column: "Name");
        }
    }
}
