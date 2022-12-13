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
                name: "UniProfileModels",
                columns: table => new
                {
                    UniID = table.Column<int>(name: "Uni_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniFullName = table.Column<string>(name: "Uni_FullName", type: "nvarchar(max)", nullable: false),
                    UniShortName = table.Column<string>(name: "Uni_ShortName", type: "nvarchar(max)", nullable: false),
                    UniDetails = table.Column<string>(name: "Uni_Details", type: "nvarchar(max)", nullable: false),
                    UniFacultyID = table.Column<int>(name: "Uni_FacultyID", type: "int", nullable: false),
                    UPicture = table.Column<byte>(name: "U_Picture", type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UniProfileModels", x => x.UniID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UniProfileModels");
        }
    }
}
