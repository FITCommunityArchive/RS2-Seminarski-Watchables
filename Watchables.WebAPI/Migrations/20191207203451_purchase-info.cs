using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Watchables.WebAPI.Migrations
{
    public partial class purchaseinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriptionDate",
                table: "UsersSubscriptions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PurchaseAmount",
                table: "UsersShows",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "UsersShows",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RotationClaimed",
                table: "UsersRotations",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PurchaseAmount",
                table: "UsersMovies",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "UsersMovies",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubscriptionDate",
                table: "UsersSubscriptions");

            migrationBuilder.DropColumn(
                name: "PurchaseAmount",
                table: "UsersShows");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "UsersShows");

            migrationBuilder.DropColumn(
                name: "RotationClaimed",
                table: "UsersRotations");

            migrationBuilder.DropColumn(
                name: "PurchaseAmount",
                table: "UsersMovies");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "UsersMovies");
        }
    }
}
