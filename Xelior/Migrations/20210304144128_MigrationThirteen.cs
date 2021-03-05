using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationThirteen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems");

            migrationBuilder.AlterColumn<long>(
                name: "JalonId",
                table: "ProjectItems",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems");

            migrationBuilder.AlterColumn<long>(
                name: "JalonId",
                table: "ProjectItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
