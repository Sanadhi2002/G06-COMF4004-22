using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.WebAdminDb
{
    /// <inheritdoc />
    public partial class DegreeContentandadmission : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree_content",
                table: "DegreeModel");

            migrationBuilder.CreateTable(
                name: "AdmissionModel",
                columns: table => new
                {
                    AdmissionId = table.Column<int>(name: "Admission_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Admissions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeID = table.Column<int>(name: "Degree_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdmissionModel", x => x.AdmissionId);
                    table.ForeignKey(
                        name: "FK_AdmissionModel_DegreeModel_Degree_ID",
                        column: x => x.DegreeID,
                        principalTable: "DegreeModel",
                        principalColumn: "Degree_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeContentModel",
                columns: table => new
                {
                    DegreeContentId = table.Column<int>(name: "DegreeContent_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreeContents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeID = table.Column<int>(name: "Degree_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeContentModel", x => x.DegreeContentId);
                    table.ForeignKey(
                        name: "FK_DegreeContentModel_DegreeModel_Degree_ID",
                        column: x => x.DegreeID,
                        principalTable: "DegreeModel",
                        principalColumn: "Degree_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdmissionModel_Degree_ID",
                table: "AdmissionModel",
                column: "Degree_ID");

            migrationBuilder.CreateIndex(
                name: "IX_DegreeContentModel_Degree_ID",
                table: "DegreeContentModel",
                column: "Degree_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdmissionModel");

            migrationBuilder.DropTable(
                name: "DegreeContentModel");

            migrationBuilder.AddColumn<string>(
                name: "Degree_content",
                table: "DegreeModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
