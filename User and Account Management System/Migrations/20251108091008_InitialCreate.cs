using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_and_Account_Management.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_AccountTypes_AccountTypeID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Branches_BranchID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Currencies_CurrencyCode1",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Users_UserID",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Banks_BankID",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Branches_BranchID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Roles_RoleID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Currencies_CurrencyCode1",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_PerformedByUserID",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Roles_RoleID",
                schema: "Training",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Users_UserID",
                schema: "Training",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CurrencyCode1",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branches",
                table: "Branches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Banks",
                table: "Banks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountTypes",
                table: "AccountTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CurrencyCode1",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "CurrencyCode1",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CurrencyCode1",
                table: "Accounts");

            migrationBuilder.RenameTable(
                name: "UserRole",
                schema: "Training",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transaction");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "RolePermissions",
                newName: "RolePermission");

            migrationBuilder.RenameTable(
                name: "Permissions",
                newName: "Permission");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Currencies",
                newName: "Currency");

            migrationBuilder.RenameTable(
                name: "Branches",
                newName: "Branch");

            migrationBuilder.RenameTable(
                name: "Banks",
                newName: "Bank");

            migrationBuilder.RenameTable(
                name: "AccountTypes",
                newName: "AccountType");

            migrationBuilder.RenameTable(
                name: "Accounts",
                newName: "Account");

            migrationBuilder.RenameIndex(
                name: "IX_Users_Email",
                table: "User",
                newName: "IX_User_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_PerformedByUserID",
                table: "Transaction",
                newName: "IX_Transaction_PerformedByUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountID",
                table: "Transaction",
                newName: "IX_Transaction_AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermissions_PermissionID",
                table: "RolePermission",
                newName: "IX_RolePermission_PermissionID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_RoleID",
                table: "Employee",
                newName: "IX_Employee_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_BranchID",
                table: "Employee",
                newName: "IX_Employee_BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_Branches_BankID",
                table: "Branch",
                newName: "IX_Branch_BankID");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_UserID",
                table: "Account",
                newName: "IX_Account_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_BranchID",
                table: "Account",
                newName: "IX_Account_BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_Accounts_AccountTypeID",
                table: "Account",
                newName: "IX_Account_AccountTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "User",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transaction",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Transaction",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Transaction",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Role",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Role",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionID",
                table: "RolePermission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "RolePermission",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "PermissionName",
                table: "Permission",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permission",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employee",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employee",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employee",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currency",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyName",
                table: "Currency",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Currency",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "IFSCCode",
                table: "Branch",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Branch",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Branch",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "Branch",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Branch",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Headquarters",
                table: "Bank",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BankName",
                table: "Bank",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "AccountType",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AccountType",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Account",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Account",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction",
                column: "TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolePermission",
                table: "RolePermission",
                columns: new[] { "RoleID", "PermissionID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permission",
                table: "Permission",
                column: "PermissionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currency",
                table: "Currency",
                column: "CurrencyCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branch",
                table: "Branch",
                column: "BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bank",
                table: "Bank",
                column: "BankID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountType",
                table: "AccountType",
                column: "AccountTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Account",
                table: "Account",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CurrencyCode",
                table: "Transaction",
                column: "CurrencyCode");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CurrencyCode",
                table: "Account",
                column: "CurrencyCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_AccountType_AccountTypeID",
                table: "Account",
                column: "AccountTypeID",
                principalTable: "AccountType",
                principalColumn: "AccountTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Branch_BranchID",
                table: "Account",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Currency_CurrencyCode",
                table: "Account",
                column: "CurrencyCode",
                principalTable: "Currency",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Account_User_UserID",
                table: "Account",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Branch_Bank_BankID",
                table: "Branch",
                column: "BankID",
                principalTable: "Bank",
                principalColumn: "BankID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee",
                column: "BranchID",
                principalTable: "Branch",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Role_RoleID",
                table: "Employee",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_Permission_PermissionID",
                table: "RolePermission",
                column: "PermissionID",
                principalTable: "Permission",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermission_Role_RoleID",
                table: "RolePermission",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Account_AccountID",
                table: "Transaction",
                column: "AccountID",
                principalTable: "Account",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Currency_CurrencyCode",
                table: "Transaction",
                column: "CurrencyCode",
                principalTable: "Currency",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_User_PerformedByUserID",
                table: "Transaction",
                column: "PerformedByUserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Role_RoleID",
                table: "UserRole",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_User_UserID",
                table: "UserRole",
                column: "UserID",
                principalTable: "User",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_AccountType_AccountTypeID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Branch_BranchID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_Currency_CurrencyCode",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Account_User_UserID",
                table: "Account");

            migrationBuilder.DropForeignKey(
                name: "FK_Branch_Bank_BankID",
                table: "Branch");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Branch_BranchID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Role_RoleID",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_Permission_PermissionID",
                table: "RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermission_Role_RoleID",
                table: "RolePermission");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Account_AccountID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Currency_CurrencyCode",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_User_PerformedByUserID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_Role_RoleID",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_User_UserID",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transaction",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CurrencyCode",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RolePermission",
                table: "RolePermission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Permission",
                table: "Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Currency",
                table: "Currency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Branch",
                table: "Branch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bank",
                table: "Bank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccountType",
                table: "AccountType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Account",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_CurrencyCode",
                table: "Account");

            migrationBuilder.EnsureSchema(
                name: "Training");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "UserRole",
                newSchema: "Training");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Transaction",
                newName: "Transactions");

            migrationBuilder.RenameTable(
                name: "RolePermission",
                newName: "RolePermissions");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Permission",
                newName: "Permissions");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Currency",
                newName: "Currencies");

            migrationBuilder.RenameTable(
                name: "Branch",
                newName: "Branches");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "Banks");

            migrationBuilder.RenameTable(
                name: "AccountType",
                newName: "AccountTypes");

            migrationBuilder.RenameTable(
                name: "Account",
                newName: "Accounts");

            migrationBuilder.RenameIndex(
                name: "IX_User_Email",
                table: "Users",
                newName: "IX_Users_Email");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_PerformedByUserID",
                table: "Transactions",
                newName: "IX_Transactions_PerformedByUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Transaction_AccountID",
                table: "Transactions",
                newName: "IX_Transactions_AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_RolePermission_PermissionID",
                table: "RolePermissions",
                newName: "IX_RolePermissions_PermissionID");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_RoleID",
                table: "Employees",
                newName: "IX_Employees_RoleID");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_BranchID",
                table: "Employees",
                newName: "IX_Employees_BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_Branch_BankID",
                table: "Branches",
                newName: "IX_Branches_BankID");

            migrationBuilder.RenameIndex(
                name: "IX_Account_UserID",
                table: "Accounts",
                newName: "IX_Accounts_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Account_BranchID",
                table: "Accounts",
                newName: "IX_Accounts_BranchID");

            migrationBuilder.RenameIndex(
                name: "IX_Account_AccountTypeID",
                table: "Accounts",
                newName: "IX_Accounts_AccountTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                schema: "Training",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                schema: "Training",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TransactionType",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Transactions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode1",
                table: "Transactions",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "PermissionID",
                table: "RolePermissions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                table: "RolePermissions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PermissionName",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Permissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Symbol",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyName",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Currencies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "IFSCCode",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ContactNumber",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BranchName",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Headquarters",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BankName",
                table: "Banks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "AccountTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "AccountTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrencyCode",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode1",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RolePermissions",
                table: "RolePermissions",
                columns: new[] { "RoleID", "PermissionID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "RoleID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Permissions",
                table: "Permissions",
                column: "PermissionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Currencies",
                table: "Currencies",
                column: "CurrencyCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Branches",
                table: "Branches",
                column: "BranchID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Banks",
                table: "Banks",
                column: "BankID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccountTypes",
                table: "AccountTypes",
                column: "AccountTypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Accounts",
                table: "Accounts",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CurrencyCode1",
                table: "Transactions",
                column: "CurrencyCode1");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CurrencyCode1",
                table: "Accounts",
                column: "CurrencyCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_AccountTypes_AccountTypeID",
                table: "Accounts",
                column: "AccountTypeID",
                principalTable: "AccountTypes",
                principalColumn: "AccountTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Branches_BranchID",
                table: "Accounts",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Currencies_CurrencyCode1",
                table: "Accounts",
                column: "CurrencyCode1",
                principalTable: "Currencies",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Users_UserID",
                table: "Accounts",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Branches_Banks_BankID",
                table: "Branches",
                column: "BankID",
                principalTable: "Banks",
                principalColumn: "BankID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Branches_BranchID",
                table: "Employees",
                column: "BranchID",
                principalTable: "Branches",
                principalColumn: "BranchID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Roles_RoleID",
                table: "Employees",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Permissions_PermissionID",
                table: "RolePermissions",
                column: "PermissionID",
                principalTable: "Permissions",
                principalColumn: "PermissionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleID",
                table: "RolePermissions",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountID",
                table: "Transactions",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Currencies_CurrencyCode1",
                table: "Transactions",
                column: "CurrencyCode1",
                principalTable: "Currencies",
                principalColumn: "CurrencyCode",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_PerformedByUserID",
                table: "Transactions",
                column: "PerformedByUserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Roles_RoleID",
                schema: "Training",
                table: "UserRole",
                column: "RoleID",
                principalTable: "Roles",
                principalColumn: "RoleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_Users_UserID",
                schema: "Training",
                table: "UserRole",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
