using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xelior.Migrations
{
    public partial class MigrationSecond : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectItemId",
                table: "JalonItem",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProjectItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssignedUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectItems_UserItems_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "UserItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JalonItem_ProjectItemId",
                table: "JalonItem",
                column: "ProjectItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectItems_AssignedUserId",
                table: "ProjectItems",
                column: "AssignedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_JalonItem_ProjectItems_ProjectItemId",
                table: "JalonItem",
                column: "ProjectItemId",
                principalTable: "ProjectItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JalonItem_ProjectItems_ProjectItemId",
                table: "JalonItem");

            migrationBuilder.DropTable(
                name: "ProjectItems");

            migrationBuilder.DropIndex(
                name: "IX_JalonItem_ProjectItemId",
                table: "JalonItem");

            migrationBuilder.DropColumn(
                name: "ProjectItemId",
                table: "JalonItem");
        }
    }
}
