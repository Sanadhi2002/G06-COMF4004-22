using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations
{
    /// <inheritdoc />
    public partial class webdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebAdmins",
                columns: table => new
                {
                    WID = table.Column<int>(name: "W_ID", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WEmail = table.Column<string>(name: "W_Email", type: "nvarchar(max)", nullable: false),
                    WPassword = table.Column<string>(name: "W_Password", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebAdmins", x => x.WID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebAdmins");
        }
    }
}
