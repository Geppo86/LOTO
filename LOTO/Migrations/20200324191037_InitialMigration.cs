using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    BID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBuilding = table.Column<string>(nullable: true),
                    Map = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.BID);
                });

            migrationBuilder.CreateTable(
                name: "ConfirmationPoint",
                columns: table => new
                {
                    CPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfirmationTagNumber = table.Column<string>(nullable: true),
                    ConfirmationDeviceType = table.Column<string>(nullable: true),
                    ConfirmationDeviceSafeStatus = table.Column<string>(nullable: true),
                    ConfirmationDevicePicture = table.Column<string>(nullable: true),
                    LocationDescription = table.Column<string>(nullable: true),
                    ConfirmationDeviceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfirmationPoint", x => x.CPID);
                });

            migrationBuilder.CreateTable(
                name: "EnergyType",
                columns: table => new
                {
                    ETID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnergyTypeName = table.Column<string>(nullable: true),
                    BackgroundColor = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnergyType", x => x.ETID);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    FID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.FID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DOB = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UID);
                });

            migrationBuilder.CreateTable(
                name: "Machine",
                columns: table => new
                {
                    MID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineSerialName = table.Column<string>(nullable: true),
                    MachineOemName = table.Column<string>(nullable: true),
                    MachineName = table.Column<string>(nullable: true),
                    BID1 = table.Column<int>(nullable: true),
                    MachinePictureFile = table.Column<string>(nullable: true),
                    MachineNamePlate = table.Column<string>(nullable: true),
                    CustomerDefinedArea = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machine", x => x.MID);
                    table.ForeignKey(
                        name: "FK_Machine_Building_BID1",
                        column: x => x.BID1,
                        principalTable: "Building",
                        principalColumn: "BID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LockoutPoint",
                columns: table => new
                {
                    LPID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LockoutTagNumber = table.Column<string>(nullable: true),
                    LocationDescription = table.Column<string>(nullable: true),
                    ETID1 = table.Column<int>(nullable: true),
                    EnergyMagnitude = table.Column<string>(nullable: true),
                    Device = table.Column<string>(nullable: true),
                    LockoutPointPicture = table.Column<string>(nullable: true),
                    MethodToIsolate = table.Column<string>(nullable: true),
                    MethodToVerify = table.Column<string>(nullable: true),
                    CPID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LockoutPoint", x => x.LPID);
                    table.ForeignKey(
                        name: "FK_LockoutPoint_ConfirmationPoint_CPID1",
                        column: x => x.CPID1,
                        principalTable: "ConfirmationPoint",
                        principalColumn: "CPID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LockoutPoint_EnergyType_ETID1",
                        column: x => x.ETID1,
                        principalTable: "EnergyType",
                        principalColumn: "ETID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Procedure",
                columns: table => new
                {
                    PID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotoOrApm = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    DateLastAudit = table.Column<string>(nullable: true),
                    UID1 = table.Column<int>(nullable: true),
                    ProcedureName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedure", x => x.PID);
                    table.ForeignKey(
                        name: "FK_Procedure_User_UID1",
                        column: x => x.UID1,
                        principalTable: "User",
                        principalColumn: "UID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MachineZone",
                columns: table => new
                {
                    MZID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MID1 = table.Column<int>(nullable: true),
                    NameMachineZone = table.Column<string>(nullable: true),
                    ZoneMapFile = table.Column<string>(nullable: true),
                    MachineZoneDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineZone", x => x.MZID);
                    table.ForeignKey(
                        name: "FK_MachineZone_Machine_MID1",
                        column: x => x.MID1,
                        principalTable: "Machine",
                        principalColumn: "MID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    TID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(nullable: true),
                    PID1 = table.Column<int>(nullable: true),
                    MZID1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.TID);
                    table.ForeignKey(
                        name: "FK_Task_MachineZone_MZID1",
                        column: x => x.MZID1,
                        principalTable: "MachineZone",
                        principalColumn: "MZID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Task_Procedure_PID1",
                        column: x => x.PID1,
                        principalTable: "Procedure",
                        principalColumn: "PID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LockoutPoint_CPID1",
                table: "LockoutPoint",
                column: "CPID1");

            migrationBuilder.CreateIndex(
                name: "IX_LockoutPoint_ETID1",
                table: "LockoutPoint",
                column: "ETID1");

            migrationBuilder.CreateIndex(
                name: "IX_Machine_BID1",
                table: "Machine",
                column: "BID1");

            migrationBuilder.CreateIndex(
                name: "IX_MachineZone_MID1",
                table: "MachineZone",
                column: "MID1");

            migrationBuilder.CreateIndex(
                name: "IX_Procedure_UID1",
                table: "Procedure",
                column: "UID1");

            migrationBuilder.CreateIndex(
                name: "IX_Task_MZID1",
                table: "Task",
                column: "MZID1");

            migrationBuilder.CreateIndex(
                name: "IX_Task_PID1",
                table: "Task",
                column: "PID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "LockoutPoint");

            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropTable(
                name: "ConfirmationPoint");

            migrationBuilder.DropTable(
                name: "EnergyType");

            migrationBuilder.DropTable(
                name: "MachineZone");

            migrationBuilder.DropTable(
                name: "Procedure");

            migrationBuilder.DropTable(
                name: "Machine");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Building");
        }
    }
}
