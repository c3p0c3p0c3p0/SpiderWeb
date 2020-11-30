using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SpiderWeb.io.Migrations
{
    public partial class MegaWatchEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppSources",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddColumn<Guid>(
                name: "AddedBy",
                table: "AppSources",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "DownVotes",
                table: "AppSources",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "AppSources",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "UpVotes",
                table: "AppSources",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppPage",
                columns: table => new
                {
                    Id = table.Column<Guid>(maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    SourceURL = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    UpVotes = table.Column<int>(nullable: false),
                    DownVotes = table.Column<int>(nullable: false),
                    SourceId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppPage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppPage_AppSources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "AppSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppComment",
                columns: table => new
                {
                    Id = table.Column<Guid>(maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    UpVotes = table.Column<int>(nullable: false),
                    DownVotes = table.Column<int>(nullable: false),
                    Owner = table.Column<Guid>(nullable: false),
                    PageId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppComment_AppPage_PageId",
                        column: x => x.PageId,
                        principalTable: "AppPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppReply",
                columns: table => new
                {
                    Id = table.Column<Guid>(maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorId = table.Column<Guid>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierId = table.Column<Guid>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    UpVotes = table.Column<int>(nullable: false),
                    DownVotes = table.Column<int>(nullable: false),
                    Owner = table.Column<Guid>(nullable: false),
                    CommentId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppReply_AppComment_CommentId",
                        column: x => x.CommentId,
                        principalTable: "AppComment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppComment_PageId",
                table: "AppComment",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_AppPage_SourceId",
                table: "AppPage",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AppReply_CommentId",
                table: "AppReply",
                column: "CommentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppReply");

            migrationBuilder.DropTable(
                name: "AppComment");

            migrationBuilder.DropTable(
                name: "AppPage");

            migrationBuilder.DropColumn(
                name: "AddedBy",
                table: "AppSources");

            migrationBuilder.DropColumn(
                name: "DownVotes",
                table: "AppSources");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "AppSources");

            migrationBuilder.DropColumn(
                name: "UpVotes",
                table: "AppSources");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AppSources",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
