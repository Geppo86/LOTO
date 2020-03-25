using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class AddNewFKonFacility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SID1",
                table: "Facility",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiteName = table.Column<string>(nullable: true),
                    SiteAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facility_SID1",
                table: "Facility",
                column: "SID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Facility_Site_SID1",
                table: "Facility",
                column: "SID1",
                principalTable: "Site",
                principalColumn: "SID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facility_Site_SID1",
                table: "Facility");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropIndex(
                name: "IX_Facility_SID1",
                table: "Facility");

            migrationBuilder.DropColumn(
                name: "SID1",
                table: "Facility");
        }
    }
}
