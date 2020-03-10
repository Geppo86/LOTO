using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class _3102020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachinePictureFile",
                table: "Machine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MachineSerialName",
                table: "Machine",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LocationDescription",
                table: "LockoutPoint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Task",
                table: "Building",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachinePictureFile",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "MachineSerialName",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "LocationDescription",
                table: "LockoutPoint");

            migrationBuilder.DropColumn(
                name: "Task",
                table: "Building");
        }
    }
}
