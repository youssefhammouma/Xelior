using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationSeven : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "ExigenceItem",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "JalonId",
                table: "ExigenceItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem");

            migrationBuilder.AlterColumn<string>(
                name: "Label",
                table: "ExigenceItem",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<long>(
                name: "JalonId",
                table: "ExigenceItem",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
