using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.CategoryDb
{
    /// <inheritdoc />
    public partial class changeColumnNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "categories");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "categories",
                newName: "U_UserName");

            migrationBuilder.RenameColumn(
                name: "OtherName",
                table: "categories",
                newName: "U_Password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "categories",
                newName: "U_Email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categories",
                newName: "U_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "U_UserName",
                table: "categories",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "U_Password",
                table: "categories",
                newName: "OtherName");

            migrationBuilder.RenameColumn(
                name: "U_Email",
                table: "categories",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "U_ID",
                table: "categories",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
