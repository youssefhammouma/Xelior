using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationSix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isChief",
                table: "UserItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "ProjectItems",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isChief",
                table: "UserItems");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "ProjectItems");
        }
    }
}
