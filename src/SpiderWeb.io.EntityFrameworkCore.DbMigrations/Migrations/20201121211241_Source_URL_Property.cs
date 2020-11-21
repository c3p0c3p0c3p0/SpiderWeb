using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiderWeb.io.Migrations
{
    public partial class Source_URL_Property : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "AppSources",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "AppSources");
        }
    }
}
