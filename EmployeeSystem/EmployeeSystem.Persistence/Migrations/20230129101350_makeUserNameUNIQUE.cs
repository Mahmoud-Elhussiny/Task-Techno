using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSystem.Persistence.Migrations
{
    public partial class makeUserNameUNIQUE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Employees_UserName",
                table: "Employees",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropUniqueConstraint(
                name: "AK_Employees_UserName",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Employees",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)");
        }
    }
}
