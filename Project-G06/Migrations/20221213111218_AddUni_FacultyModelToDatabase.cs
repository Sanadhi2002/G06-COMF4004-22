using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations
{
    /// <inheritdoc />
    public partial class AddUniFacultyModelToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnifacultyModels",
                columns: table => new
                {
                    UniFacultyID = table.Column<int>(name: "Uni_Faculty_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(name: "Faculty_Name", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnifacultyModels", x => x.UniFacultyID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnifacultyModels");
        }
    }
}
