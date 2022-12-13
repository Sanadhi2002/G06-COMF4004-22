using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectG06.Migrations
{
    /// <inheritdoc />
    public partial class WebsiteAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebsiteAdmins",
                columns: table => new
                {
                    WId = table.Column<int>(name: "W_Id", type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WUserName = table.Column<string>(name: "W_UserName", type: "nvarchar(max)", nullable: false),
                    WEmail = table.Column<string>(name: "W_Email", type: "nvarchar(max)", nullable: false),
                    WPassword = table.Column<string>(name: "W_Password", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebsiteAdmins", x => x.WId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebsiteAdmins");
        }
    }
}
