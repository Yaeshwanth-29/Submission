using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_and_Account_Management.Migrations
{
    /// <inheritdoc />
    public partial class Initialsetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Training");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRole",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "User",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transaction",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "RolePermission",
                newName: "RolePermission",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Role",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permission",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employee",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Currency",
                newName: "Currency",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Branch",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "Bank",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "AccountType",
                newName: "AccountType",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Account",
                newSchema: "Training");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "UserRole",
                schema: "Training",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Training",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Transaction",
                schema: "Training",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "RolePermission",
                schema: "Training",
                newName: "RolePermission");

            migrationBuilder.RenameTable(
                name: "Role",
                schema: "Training",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Permission",
                schema: "Training",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "Employee",
                schema: "Training",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Currency",
                schema: "Training",
                newName: "Currency");

            migrationBuilder.RenameTable(
                name: "Branch",
                schema: "Training",
                newName: "Branch");

            migrationBuilder.RenameTable(
                name: "Bank",
                schema: "Training",
                newName: "Bank");

            migrationBuilder.RenameTable(
                name: "AccountType",
                schema: "Training",
                newName: "AccountType");

            migrationBuilder.RenameTable(
                name: "Account",
                schema: "Training",
                newName: "Account");
        }
    }
}
