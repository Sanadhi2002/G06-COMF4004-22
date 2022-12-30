using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.WebAdminDb
{
    /// <inheritdoc />
    public partial class degree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniProfileModel",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UniShortname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniFullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilPicURL = table.Column<string>(name: "ProfilPic_URL", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniProfileModel", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_UniProfileModel_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DegreeModel",
                columns: table => new
                {
                    DegreeID = table.Column<int>(name: "Degree_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DegreName = table.Column<string>(name: "Degre_Name", type: "nvarchar(max)", nullable: false),
                    DegreeType = table.Column<string>(name: "Degree_Type", type: "nvarchar(max)", nullable: false),
                    Affiliateduni = table.Column<string>(name: "Affiliated_uni", type: "nvarchar(max)", nullable: false),
                    Degreeduration = table.Column<string>(name: "Degree_duration", type: "nvarchar(max)", nullable: false),
                    Degreedescription = table.Column<string>(name: "Degree_description", type: "nvarchar(max)", nullable: false),
                    CourseFee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerOpurtunity = table.Column<string>(name: "Career_Opurtunity", type: "nvarchar(max)", nullable: false),
                    Academicproggression = table.Column<string>(name: "Academic_proggression", type: "nvarchar(max)", nullable: false),
                    AdmissionRequirments = table.Column<string>(name: "Admission_Requirments", type: "nvarchar(max)", nullable: false),
                    Degreecontent = table.Column<string>(name: "Degree_content", type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DegreeModel", x => x.DegreeID);
                    table.ForeignKey(
                        name: "FK_DegreeModel_UniProfileModel_UserId",
                        column: x => x.UserId,
                        principalTable: "UniProfileModel",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DegreeModel_UserId",
                table: "DegreeModel",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DegreeModel");

            migrationBuilder.DropTable(
                name: "UniProfileModel");
        }
    }
}
