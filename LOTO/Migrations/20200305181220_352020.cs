using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class _352020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machine_MachineZone_ZoneId",
                table: "Machine");

            migrationBuilder.DropIndex(
                name: "IX_Machine_ZoneId",
                table: "Machine");

            migrationBuilder.DropColumn(
                name: "HatchingFile",
                table: "MachineZone");

            migrationBuilder.DropColumn(
                name: "ZoneId",
                table: "Machine");

            migrationBuilder.CreateTable(
                name: "Building",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBuilding = table.Column<string>(nullable: true),
                    Map = table.Column<string>(nullable: true),
                    Coordinates = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Building", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Facility",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(nullable: true),
                    FacilityLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facility", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Last = table.Column<string>(nullable: true),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Building");

            migrationBuilder.DropTable(
                name: "Facility");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.AddColumn<string>(
                name: "HatchingFile",
                table: "MachineZone",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ZoneId",
                table: "Machine",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Machine_ZoneId",
                table: "Machine",
                column: "ZoneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machine_MachineZone_ZoneId",
                table: "Machine",
                column: "ZoneId",
                principalTable: "MachineZone",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
