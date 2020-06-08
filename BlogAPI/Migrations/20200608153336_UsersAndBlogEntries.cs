using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogAPI.Migrations
{
    public partial class UsersAndBlogEntries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogEntry",
                schema: "BlogKata",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    BlogID = table.Column<Guid>(nullable: false),
                    HeadingText = table.Column<string>(nullable: true),
                    EntryText = table.Column<string>(nullable: true),
                    UserID = table.Column<Guid>(nullable: false),
                    EntryDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogEntry", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "BlogKata",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogEntry",
                schema: "BlogKata");

            migrationBuilder.DropTable(
                name: "User",
                schema: "BlogKata");
        }
    }
}
