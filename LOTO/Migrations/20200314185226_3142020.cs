using Microsoft.EntityFrameworkCore.Migrations;

namespace LOTO.Migrations
{
    public partial class _3142020 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Coordinates",
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

            migrationBuilder.AddColumn<string>(
                name: "Coordinates",
                table: "Building",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
