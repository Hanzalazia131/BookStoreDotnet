using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.BookStore.Migrations
{
    public partial class Added_Authors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppYourEntities",
                table: "AppYourEntities");

            migrationBuilder.RenameTable(
                name: "AppYourEntities",
                newName: "AppAuthors");

            migrationBuilder.RenameIndex(
                name: "IX_AppYourEntities_Name",
                table: "AppAuthors",
                newName: "IX_AppAuthors_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAuthors",
                table: "AppAuthors",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAuthors",
                table: "AppAuthors");

            migrationBuilder.RenameTable(
                name: "AppAuthors",
                newName: "AppYourEntities");

            migrationBuilder.RenameIndex(
                name: "IX_AppAuthors_Name",
                table: "AppYourEntities",
                newName: "IX_AppYourEntities_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppYourEntities",
                table: "AppYourEntities",
                column: "Id");
        }
    }
}
