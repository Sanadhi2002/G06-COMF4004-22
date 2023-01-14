using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.WebApplication2Db
{
    /// <inheritdoc />
    public partial class @short : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DegreeModel_UniProfileModel_UniShortname",
                table: "DegreeModel");

            migrationBuilder.DropIndex(
                name: "IX_DegreeModel_UniShortname",
                table: "DegreeModel");

            migrationBuilder.AlterColumn<string>(
                name: "UniShortname",
                table: "DegreeModel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UniShortname",
                table: "DegreeModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DegreeModel_UniShortname",
                table: "DegreeModel",
                column: "UniShortname");

            migrationBuilder.AddForeignKey(
                name: "FK_DegreeModel_UniProfileModel_UniShortname",
                table: "DegreeModel",
                column: "UniShortname",
                principalTable: "UniProfileModel",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
