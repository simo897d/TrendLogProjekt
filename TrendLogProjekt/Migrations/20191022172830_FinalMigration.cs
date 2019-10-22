using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendLogProjekt.Migrations
{
    public partial class FinalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "topAuthors",
                newName: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "bandwithReports");

            migrationBuilder.DropTable(
                name: "topAuthors");
        }
    }
}
