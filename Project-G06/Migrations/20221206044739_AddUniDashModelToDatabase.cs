using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations
{
    /// <inheritdoc />
    public partial class AddUniDashModelToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "uniDashModels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UniDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DegreeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddmissionReq = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfSem = table.Column<int>(type: "int", nullable: false),
                    CareerOp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseFee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UGC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AffUni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicProg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uniDashModels", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "uniDashModels");
        }
    }
}
