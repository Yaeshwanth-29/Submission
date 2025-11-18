using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_and_Account_Management.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BankID",
                schema: "Training",
                table: "Account",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Account_BankID",
                schema: "Training",
                table: "Account",
                column: "BankID");

            migrationBuilder.AddForeignKey(
                name: "FK_Account_Bank_BankID",
                schema: "Training",
                table: "Account",
                column: "BankID",
                principalSchema: "Training",
                principalTable: "Bank",
                principalColumn: "BankID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Account_Bank_BankID",
                schema: "Training",
                table: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Account_BankID",
                schema: "Training",
                table: "Account");

            migrationBuilder.DropColumn(
                name: "BankID",
                schema: "Training",
                table: "Account");
        }
    }
}
