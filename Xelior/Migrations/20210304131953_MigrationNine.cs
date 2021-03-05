using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationNine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem");

            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_ProjectItems_ProjectItemId",
                table: "JalonItem");

            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_JalonItem_JalonItemId",
                table: "TaskItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_UserItems_AssignedUserId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_TaskItem_AssignedUserId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_TaskItem_JalonItemId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_JalonItem_ProjectItemId",
                table: "JalonItem");

            migrationBuilder.DropIndex(
                name: "IX_ExigenceItem_JalonId",
                table: "ExigenceItem");

            migrationBuilder.DropColumn(
                name: "AssignedUserId",
                table: "TaskItem");

            migrationBuilder.DropColumn(
                name: "JalonItemId",
                table: "TaskItem");

            migrationBuilder.DropColumn(
                name: "ProjectItemId",
                table: "JalonItem");

            migrationBuilder.RenameColumn(
                name: "ExigencesId",
                table: "TaskItem",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AssignedUserId",
                table: "JalonItem",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_JalonItem_AssignedUserId",
                table: "JalonItem",
                newName: "IX_JalonItem_TaskId");

            migrationBuilder.AddColumn<long>(
                name: "JalonId",
                table: "ProjectItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ExigenceId",
                table: "JalonItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_UserId",
                table: "TaskItem",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItems_JalonId",
                table: "ProjectItems",
                column: "JalonId");

            migrationBuilder.CreateIndex(
                name: "IX_JalonItem_ExigenceId",
                table: "JalonItem",
                column: "ExigenceId");

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_ExigenceItem_ExigenceId",
                table: "JalonItem",
                column: "ExigenceId",
                principalTable: "ExigenceItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_TaskItem_TaskId",
                table: "JalonItem",
                column: "TaskId",
                principalTable: "TaskItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_UserItems_UserId",
                table: "TaskItem",
                column: "UserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_ExigenceItem_ExigenceId",
                table: "JalonItem");

            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_TaskItem_TaskId",
                table: "JalonItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectItems_JalonItem_JalonId",
                table: "ProjectItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItem_UserItems_UserId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_TaskItem_UserId",
                table: "TaskItem");

            migrationBuilder.DropIndex(
                name: "IX_ProjectItems_JalonId",
                table: "ProjectItems");

            migrationBuilder.DropIndex(
                name: "IX_JalonItem_ExigenceId",
                table: "JalonItem");

            migrationBuilder.DropColumn(
                name: "JalonId",
                table: "ProjectItems");

            migrationBuilder.DropColumn(
                name: "ExigenceId",
                table: "JalonItem");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TaskItem",
                newName: "ExigencesId");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "JalonItem",
                newName: "AssignedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_JalonItem_TaskId",
                table: "JalonItem",
                newName: "IX_JalonItem_AssignedUserId");

            migrationBuilder.AddColumn<long>(
                name: "AssignedUserId",
                table: "TaskItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "JalonItemId",
                table: "TaskItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProjectItemId",
                table: "JalonItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_AssignedUserId",
                table: "TaskItem",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_JalonItemId",
                table: "TaskItem",
                column: "JalonItemId");

            migrationBuilder.CreateIndex(
                name: "IX_JalonItem_ProjectItemId",
                table: "JalonItem",
                column: "ProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ExigenceItem_JalonId",
                table: "ExigenceItem",
                column: "JalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExigenceItem_JalonItem_JalonId",
                table: "ExigenceItem",
                column: "JalonId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_ProjectItems_ProjectItemId",
                table: "JalonItem",
                column: "ProjectItemId",
                principalTable: "ProjectItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_UserItems_AssignedUserId",
                table: "JalonItem",
                column: "AssignedUserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_JalonItem_JalonItemId",
                table: "TaskItem",
                column: "JalonItemId",
                principalTable: "JalonItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItem_UserItems_AssignedUserId",
                table: "TaskItem",
                column: "AssignedUserId",
                principalTable: "UserItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
