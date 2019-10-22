using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendLogProjekt.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SubmittedTickets",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "ServerAllocation",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "GeneratedLeads2",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "GeneratedLeads",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.CreateTable(
                name: "topAuthors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Occupation = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    Money = table.Column<int>(nullable: false),
                    ImageLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topAuthors", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "topAuthors");

            migrationBuilder.AlterColumn<double>(
                name: "SubmittedTickets",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "ServerAllocation",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "GeneratedLeads2",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "GeneratedLeads",
                table: "bandwithReports",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
