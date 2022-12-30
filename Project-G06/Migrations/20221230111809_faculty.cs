using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations.WebAdminDb
{
    /// <inheritdoc />
    public partial class faculty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UniFacultyModel",
                columns: table => new
                {
                    UniFacultyID = table.Column<int>(name: "Uni_Faculty_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(name: "Faculty_Name", type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniFacultyModel", x => x.UniFacultyID);
                    table.ForeignKey(
                        name: "FK_UniFacultyModel_UniProfileModel_UserId",
                        column: x => x.UserId,
                        principalTable: "UniProfileModel",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniFacultyModel_UserId",
                table: "UniFacultyModel",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniFacultyModel");
        }
    }
}
