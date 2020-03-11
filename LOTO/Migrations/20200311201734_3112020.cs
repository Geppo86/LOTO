using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class _3112020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Procedure_LockoutPoint_LockoutpointID",
                table: "Procedure");

            migrationBuilder.DropForeignKey(
                name: "FK_Task_Procedure_ProcedureId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProcedureId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Procedure_LockoutpointID",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "Last",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ProcedureId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "LockoutpointID",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "step",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "MachineMap",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "ConfirmationDeviceNumber1",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "ConfirmationDeviceNumber2",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "ConfirmationDeviceNumber3",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "EnergyType",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "Task",
                table: "Building");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "User",
                newName: "DOB");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "User",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "AuthorizationLevel",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeID",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DateLastAudit",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOTOorAPM",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameLastAudit",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcedureID",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcedureName",
                table: "Procedure",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineZoneDescription",
                table: "MachineZone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerDefinedArea",
                table: "Machine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineNamePlate",
                table: "Machine",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LockoutTagNumber",
                table: "LockoutPoint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ConfirmationDeviceID",
                table: "LockoutPoint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EnergyTypeID",
                table: "LockoutPoint",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorizationLevel",
                table: "User");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DateLastAudit",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "LOTOorAPM",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "NameLastAudit",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "ProcedureID",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "ProcedureName",
                table: "Procedure");

            migrationBuilder.DropColumn(
                name: "MachineZoneDescription",
                table: "MachineZone");

            migrationBuilder.DropColumn(
                name: "CustomerDefinedArea",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "MachineNamePlate",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "ConfirmationDeviceID",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "EnergyTypeID",
                table: "LockoutPoint");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "User",
                newName: "Dob");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "User",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "Last",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProcedureId",
                table: "Task",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LockoutpointID",
                table: "Procedure",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Procedure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "step",
                table: "Procedure",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineMap",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Machine",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LockoutTagNumber",
                table: "LockoutPoint",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationDeviceNumber1",
                table: "LockoutPoint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationDeviceNumber2",
                table: "LockoutPoint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationDeviceNumber3",
                table: "LockoutPoint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnergyType",
                table: "LockoutPoint",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Task",
                table: "Building",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProcedureId",
                table: "Task",
                column: "ProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedure_LockoutpointID",
                table: "Procedure",
                column: "LockoutpointID");

            migrationBuilder.AddForeignKey(
                name: "FK_Procedure_LockoutPoint_LockoutpointID",
                table: "Procedure",
                column: "LockoutpointID",
                principalTable: "LockoutPoint",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Procedure_ProcedureId",
                table: "Task",
                column: "ProcedureId",
                principalTable: "Procedure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
