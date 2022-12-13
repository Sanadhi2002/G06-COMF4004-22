using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations
{
    /// <inheritdoc />
    public partial class AddUniProfileModelToDatabase : Migration
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

            migrationBuilder.CreateTable(
                name: "UniProfileModels",
                columns: table => new
                {
                    UniID = table.Column<int>(name: "Uni_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniFullName = table.Column<string>(name: "Uni_FullName", type: "nvarchar(max)", nullable: false),
                    UniShortName = table.Column<string>(name: "Uni_ShortName", type: "nvarchar(max)", nullable: false),
                    UniDetails = table.Column<string>(name: "Uni_Details", type: "nvarchar(max)", nullable: false),
                    UPicture = table.Column<byte>(name: "U_Picture", type: "tinyint", nullable: true),
                    UniFacultyID = table.Column<int>(name: "Uni_Faculty_ID", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniProfileModels", x => x.UniID);
                    table.ForeignKey(
                        name: "FK_UniProfileModels_UnifacultyModels_Uni_Faculty_ID",
                        column: x => x.UniFacultyID,
                        principalTable: "UnifacultyModels",
                        principalColumn: "Uni_Faculty_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UniProfileModels_Uni_Faculty_ID",
                table: "UniProfileModels",
                column: "Uni_Faculty_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniProfileModels");

            migrationBuilder.DropTable(
                name: "UnifacultyModels");
        }
    }
}
