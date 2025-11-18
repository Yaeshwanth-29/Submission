using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace User_and_Account_Management.Migrations
{
    /// <inheritdoc />
    public partial class _1final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                schema: "Training",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiry",
                schema: "Training",
                table: "User",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                schema: "Training",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiry",
                schema: "Training",
                table: "User");

            migrationBuilder.AlterColumn<int>(
                name: "RoleID",
                schema: "Training",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                schema: "Training",
                table: "UserRole",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);
        }
    }
}
