using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class FirstMigraton225246 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcedureName",
                table: "Task");

            migrationBuilder.AddColumn<int>(
                name: "ProcedureId",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Task",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineOemName",
                table: "Machine",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Machine",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "MachineZone",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone = table.Column<string>(nullable: true),
                    ZoneMapFile = table.Column<string>(nullable: true),
                    HatchingFile = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineZone", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    step = table.Column<string>(nullable: true),
                    LockoutpointID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Procedure_LockoutPoint_LockoutpointID",
                        column: x => x.LockoutpointID,
                        principalTable: "LockoutPoint",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProcedureId",
                table: "Task",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ZoneId",
                table: "Task",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_ZoneId",
                table: "Machine",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedure_LockoutpointID",
                table: "Procedure",
                column: "LockoutpointID");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_MachineZone_ZoneId",
                table: "Machine",
                column: "ZoneId",
                principalTable: "MachineZone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Procedure_ProcedureId",
                table: "Task",
                column: "ProcedureId",
                principalTable: "Procedure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_MachineZone_ZoneId",
                table: "Task",
                column: "ZoneId",
                principalTable: "MachineZone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machine_MachineZone_ZoneId",
                table: "Machine");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Procedure_ProcedureId",
                table: "Task");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_MachineZone_ZoneId",
                table: "Task");

            migrationBuilder.DropTable(
                name: "MachineZone");

            migrationBuilder.DropTable(
                name: "Procedure");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProcedureId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ZoneId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Machine_ZoneId",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "MachineOemName",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Machine");

            migrationBuilder.AddColumn<string>(
                name: "ProcedureName",
                table: "Task",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
