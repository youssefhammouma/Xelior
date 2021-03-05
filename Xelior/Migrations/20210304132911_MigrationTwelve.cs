using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationTwelve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_UserItems_AssignedUserId",
                table: "ProjectItems");

            migrationBuilder.DropIndex(
                name: "IX_ProjectItems_AssignedUserId",
                table: "ProjectItems");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "ProjectItems");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "ProjectItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProjectItems");

            migrationBuilder.AddColumn<long>(
                name: "AssignedUserId",
                table: "ProjectItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItems_AssignedUserId",
                table: "ProjectItems",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_UserItems_AssignedUserId",
                table: "ProjectItems",
                column: "AssignedUserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
