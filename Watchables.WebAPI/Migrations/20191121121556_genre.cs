using Microsoft.EntityFrameworkCore.Migrations;

namespace Watchables.WebAPI.Migrations
{
    public partial class genre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Shows",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Movies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movies");
        }
    }
}
