using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class AddNewFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FID1",
                table: "Building",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Building_FID1",
                table: "Building",
                column: "FID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Building_Facility_FID1",
                table: "Building",
                column: "FID1",
                principalTable: "Facility",
                principalColumn: "FID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Building_Facility_FID1",
                table: "Building");

            migrationBuilder.DropIndex(
                name: "IX_Building_FID1",
                table: "Building");

            migrationBuilder.DropColumn(
                name: "FID1",
                table: "Building");
        }
    }
}
