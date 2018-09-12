using Microsoft.EntityFrameworkCore.Migrations;

namespace OneWorkFlow.Migrations
{
    public partial class update_ComponentInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkFlowStatus_ComponentInfo_componentId",
                schema: "WF",
                table: "WorkFlowStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WorkFlowStatus",
                schema: "WF",
                table: "WorkFlowStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComponentInfo",
                schema: "WF",
                table: "ComponentInfo");

            migrationBuilder.RenameTable(
                name: "WorkFlowStatus",
                schema: "WF",
                newName: "wf_WorkFlowStatus");

            migrationBuilder.RenameTable(
                name: "ComponentInfo",
                schema: "WF",
                newName: "wf_ComponentInfo");

            migrationBuilder.RenameIndex(
                name: "IX_WorkFlowStatus_componentId",
                table: "wf_WorkFlowStatus",
                newName: "IX_wf_WorkFlowStatus_componentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wf_WorkFlowStatus",
                table: "wf_WorkFlowStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_wf_ComponentInfo",
                table: "wf_ComponentInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_wf_WorkFlowStatus_wf_ComponentInfo_componentId",
                table: "wf_WorkFlowStatus",
                column: "componentId",
                principalTable: "wf_ComponentInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_wf_WorkFlowStatus_wf_ComponentInfo_componentId",
                table: "wf_WorkFlowStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wf_WorkFlowStatus",
                table: "wf_WorkFlowStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_wf_ComponentInfo",
                table: "wf_ComponentInfo");

            migrationBuilder.EnsureSchema(
                name: "WF");

            migrationBuilder.RenameTable(
                name: "wf_WorkFlowStatus",
                newName: "WorkFlowStatus",
                newSchema: "WF");

            migrationBuilder.RenameTable(
                name: "wf_ComponentInfo",
                newName: "ComponentInfo",
                newSchema: "WF");

            migrationBuilder.RenameIndex(
                name: "IX_wf_WorkFlowStatus_componentId",
                schema: "WF",
                table: "WorkFlowStatus",
                newName: "IX_WorkFlowStatus_componentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WorkFlowStatus",
                schema: "WF",
                table: "WorkFlowStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComponentInfo",
                schema: "WF",
                table: "ComponentInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkFlowStatus_ComponentInfo_componentId",
                schema: "WF",
                table: "WorkFlowStatus",
                column: "componentId",
                principalSchema: "WF",
                principalTable: "ComponentInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
