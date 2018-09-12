using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OneWorkFlow.Migrations
{
    public partial class _20180912_Add_ComponentInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "WF");

            migrationBuilder.CreateTable(
                name: "ComponentInfo",
                schema: "WF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    DeleterUserId = table.Column<long>(nullable: true),
                    DeletionTime = table.Column<DateTime>(nullable: true),
                    ComponentName = table.Column<string>(nullable: false),
                    ComponentSort = table.Column<string>(nullable: false),
                    IsCompleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkFlowStatus",
                schema: "WF",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FlowId = table.Column<string>(nullable: true),
                    StepId = table.Column<string>(nullable: true),
                    TaskId = table.Column<string>(nullable: true),
                    InstanceId = table.Column<string>(nullable: true),
                    IsCompleted = table.Column<bool>(nullable: false),
                    componentId = table.Column<int>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    CreationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkFlowStatus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkFlowStatus_ComponentInfo_componentId",
                        column: x => x.componentId,
                        principalSchema: "WF",
                        principalTable: "ComponentInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkFlowStatus_componentId",
                schema: "WF",
                table: "WorkFlowStatus",
                column: "componentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkFlowStatus",
                schema: "WF");

            migrationBuilder.DropTable(
                name: "ComponentInfo",
                schema: "WF");
        }
    }
}
