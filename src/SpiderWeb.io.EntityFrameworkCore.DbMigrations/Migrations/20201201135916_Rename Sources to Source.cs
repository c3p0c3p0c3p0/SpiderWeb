using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiderWeb.io.Migrations
{
    public partial class RenameSourcestoSource : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPage_AppSources_SourceId",
                table: "AppPage");

            migrationBuilder.DropTable(
                name: "AppSources");

            migrationBuilder.CreateTable(
                name: "AppSource",
                columns: table => new
                {
                    Id = table.Column<Guid>(maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AddedBy = table.Column<Guid>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    UpVotes = table.Column<int>(nullable: false),
                    DownVotes = table.Column<int>(nullable: false),
                    SourceType = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    ContentType = table.Column<int>(nullable: false),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    Tags = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSource", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AppPage_AppSource_SourceId",
                table: "AppPage",
                column: "SourceId",
                principalTable: "AppSource",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppPage_AppSource_SourceId",
                table: "AppPage");

            migrationBuilder.DropTable(
                name: "AppSource");

            migrationBuilder.CreateTable(
                name: "AppSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 128, nullable: false),
                    AddedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true),
                    ContentType = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DownVotes = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    SourceType = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpVotes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSources", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AppPage_AppSources_SourceId",
                table: "AppPage",
                column: "SourceId",
                principalTable: "AppSources",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
