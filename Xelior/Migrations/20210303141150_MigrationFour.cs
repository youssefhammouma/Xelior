using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationFour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem");

            migrationBuilder.AlterColumn<long>(
                name: "AssignedUserId",
                table: "JalonItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem",
                column: "AssignedUserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem");

            migrationBuilder.AlterColumn<long>(
                name: "AssignedUserId",
                table: "JalonItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem",
                column: "AssignedUserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
