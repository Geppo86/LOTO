using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LockoutPoint",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LockoutTagNumber = table.Column<int>(nullable: false),
                    EnergyType = table.Column<string>(nullable: true),
                    EnergyMagnitude = table.Column<string>(nullable: true),
                    Device = table.Column<string>(nullable: true),
                    MethodToIsolate = table.Column<string>(nullable: true),
                    MethodToVerify = table.Column<string>(nullable: true),
                    ConfirmationDeviceNumber1 = table.Column<string>(nullable: true),
                    ConfirmationDeviceNumber2 = table.Column<string>(nullable: true),
                    ConfirmationDeviceNumber3 = table.Column<string>(nullable: true),
                    LockoutPointPicture = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockoutPoint", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(nullable: true),
                    Site = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    MachineMap = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(nullable: true),
                    ProcedureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LockoutPoint");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "Task");
        }
    }
}
