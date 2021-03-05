using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationInitiate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TodoItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    IsComplete = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TodoItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Trigram = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JalonItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PlannedStartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    AssignedUserId = table.Column<long>(type: "bigint", nullable: true),
                    RealEndDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JalonItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JalonItem_UserItems_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "UserItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    AssignedUserId = table.Column<long>(type: "bigint", nullable: true),
                    PlannedStartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RealStartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    RequiredTaskId = table.Column<long>(type: "bigint", nullable: true),
                    JalonItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskItem_JalonItem_JalonItemId",
                        column: x => x.JalonItemId,
                        principalTable: "JalonItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskItem_TaskItem_RequiredTaskId",
                        column: x => x.RequiredTaskId,
                        principalTable: "TaskItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskItem_UserItems_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "UserItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExigenceItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    JalonId = table.Column<long>(type: "bigint", nullable: true),
                    TaskItemId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExigenceItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExigenceItem_JalonItem_JalonId",
                        column: x => x.JalonId,
                        principalTable: "JalonItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExigenceItem_TaskItem_TaskItemId",
                        column: x => x.TaskItemId,
                        principalTable: "TaskItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExigenceItem_JalonId",
                table: "ExigenceItem",
                column: "JalonId");

            migrationBuilder.CreateIndex(
                name: "IX_ExigenceItem_TaskItemId",
                table: "ExigenceItem",
                column: "TaskItemId");

            migrationBuilder.CreateIndex(
                name: "IX_JalonItem_AssignedUserId",
                table: "JalonItem",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_AssignedUserId",
                table: "TaskItem",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_JalonItemId",
                table: "TaskItem",
                column: "JalonItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItem_RequiredTaskId",
                table: "TaskItem",
                column: "RequiredTaskId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExigenceItem");

            migrationBuilder.DropTable(
                name: "TodoItems");

            migrationBuilder.DropTable(
                name: "TaskItem");

            migrationBuilder.DropTable(
                name: "JalonItem");

            migrationBuilder.DropTable(
                name: "UserItems");
        }
    }
}
