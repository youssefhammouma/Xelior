using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationEight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExigenceItem_TaskItem_TaskItemId",
                table: "ExigenceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_TaskItem_RequiredTaskId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_TaskItem_RequiredTaskId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_ExigenceItem_TaskItemId",
                table: "ExigenceItem");

            migrationBuilder.DropColumn(
                name: "RequiredTaskId",
                table: "TaskItem");

            migrationBuilder.DropColumn(
                name: "TaskItemId",
                table: "ExigenceItem");

            migrationBuilder.AddColumn<long>(
                name: "ExigencesId",
                table: "TaskItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExigencesId",
                table: "TaskItem");

            migrationBuilder.AddColumn<long>(
                name: "RequiredTaskId",
                table: "TaskItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TaskItemId",
                table: "ExigenceItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_RequiredTaskId",
                table: "TaskItem",
                column: "RequiredTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_ExigenceItem_TaskItemId",
                table: "ExigenceItem",
                column: "TaskItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExigenceItem_TaskItem_TaskItemId",
                table: "ExigenceItem",
                column: "TaskItemId",
                principalTable: "TaskItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_TaskItem_RequiredTaskId",
                table: "TaskItem",
                column: "RequiredTaskId",
                principalTable: "TaskItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
