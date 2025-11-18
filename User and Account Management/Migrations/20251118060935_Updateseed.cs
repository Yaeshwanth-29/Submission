using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace User_and_Account_Management.Migrations
{
    /// <inheritdoc />
    public partial class Updateseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Training",
                table: "Branch",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "Training",
                table: "Bank",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                schema: "Training",
                table: "Bank",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                schema: "Training",
                table: "AccountType",
                columns: new[] { "AccountTypeID", "Description", "TypeName" },
                values: new object[,]
                {
                    { 1, null, "Savings" },
                    { 2, null, "Current" },
                    { 3, null, "Salary" }
                });

            migrationBuilder.InsertData(
                schema: "Training",
                table: "Bank",
                columns: new[] { "BankID", "BankName", "CreatedDate", "EstablishedDate", "Headquarters", "IsActive", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Bank of India", new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(557), null, null, true, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(90) },
                    { 2, "ICICI Bank", new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(703), null, null, true, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(701) },
                    { 3, "HDFC Bank", new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(704), null, null, true, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(704) },
                    { 4, "AXIS Bank", new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(705), null, null, true, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(705) },
                    { 5, "SBI Bank", new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(707), null, null, true, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(706) }
                });

            migrationBuilder.InsertData(
                schema: "Training",
                table: "Currency",
                columns: new[] { "CurrencyCode", "CurrencyName", "Symbol" },
                values: new object[,]
                {
                    { "EUR", "Euro", "" },
                    { "INR", "Indian Rupee", "" },
                    { "USD", "US Dollar", "" }
                });

            migrationBuilder.InsertData(
                schema: "Training",
                table: "User",
                columns: new[] { "UserID", "Address", "CreatedDate", "DOB", "Email", "FullName", "IsActive", "IsMinor", "ModifiedDate", "PasswordHash", "PhoneNumber", "RefreshToken", "RefreshTokenExpiry", "Username" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2025, 11, 18, 6, 9, 34, 657, DateTimeKind.Utc).AddTicks(9914), null, "user1@mail.com", "User 1", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(93), "cGFzc3dvcmQ=", null, null, null, "user1" },
                    { 2, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(427), null, "user2@mail.com", "User 2", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(428), "cGFzc3dvcmQ=", null, null, null, "user2" },
                    { 3, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(432), null, "user3@mail.com", "User 3", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(432), "cGFzc3dvcmQ=", null, null, null, "user3" },
                    { 4, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(435), null, "user4@mail.com", "User 4", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(436), "cGFzc3dvcmQ=", null, null, null, "user4" },
                    { 5, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(438), null, "user5@mail.com", "User 5", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(439), "cGFzc3dvcmQ=", null, null, null, "user5" },
                    { 6, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(450), null, "user6@mail.com", "User 6", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(450), "cGFzc3dvcmQ=", null, null, null, "user6" },
                    { 7, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(452), null, "user7@mail.com", "User 7", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(452), "cGFzc3dvcmQ=", null, null, null, "user7" },
                    { 8, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(455), null, "user8@mail.com", "User 8", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(455), "cGFzc3dvcmQ=", null, null, null, "user8" },
                    { 9, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(457), null, "user9@mail.com", "User 9", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(457), "cGFzc3dvcmQ=", null, null, null, "user9" },
                    { 10, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(462), null, "user10@mail.com", "User 10", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(462), "cGFzc3dvcmQ=", null, null, null, "user10" },
                    { 11, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(465), null, "user11@mail.com", "User 11", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(465), "cGFzc3dvcmQ=", null, null, null, "user11" },
                    { 12, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(467), null, "user12@mail.com", "User 12", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(467), "cGFzc3dvcmQ=", null, null, null, "user12" },
                    { 13, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(470), null, "user13@mail.com", "User 13", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(470), "cGFzc3dvcmQ=", null, null, null, "user13" },
                    { 14, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(473), null, "user14@mail.com", "User 14", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(473), "cGFzc3dvcmQ=", null, null, null, "user14" },
                    { 15, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(475), null, "user15@mail.com", "User 15", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(475), "cGFzc3dvcmQ=", null, null, null, "user15" },
                    { 16, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(478), null, "user16@mail.com", "User 16", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(478), "cGFzc3dvcmQ=", null, null, null, "user16" },
                    { 17, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(480), null, "user17@mail.com", "User 17", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(480), "cGFzc3dvcmQ=", null, null, null, "user17" },
                    { 18, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(484), null, "user18@mail.com", "User 18", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(484), "cGFzc3dvcmQ=", null, null, null, "user18" },
                    { 19, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(486), null, "user19@mail.com", "User 19", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(486), "cGFzc3dvcmQ=", null, null, null, "user19" },
                    { 20, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(489), null, "user20@mail.com", "User 20", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(489), "cGFzc3dvcmQ=", null, null, null, "user20" },
                    { 21, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(513), null, "user21@mail.com", "User 21", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(514), "cGFzc3dvcmQ=", null, null, null, "user21" },
                    { 22, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(517), null, "user22@mail.com", "User 22", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(517), "cGFzc3dvcmQ=", null, null, null, "user22" },
                    { 23, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(519), null, "user23@mail.com", "User 23", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(520), "cGFzc3dvcmQ=", null, null, null, "user23" },
                    { 24, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(522), null, "user24@mail.com", "User 24", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(522), "cGFzc3dvcmQ=", null, null, null, "user24" },
                    { 25, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(525), null, "user25@mail.com", "User 25", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(525), "cGFzc3dvcmQ=", null, null, null, "user25" },
                    { 26, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(527), null, "user26@mail.com", "User 26", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(527), "cGFzc3dvcmQ=", null, null, null, "user26" },
                    { 27, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(530), null, "user27@mail.com", "User 27", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(530), "cGFzc3dvcmQ=", null, null, null, "user27" },
                    { 28, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(532), null, "user28@mail.com", "User 28", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(533), "cGFzc3dvcmQ=", null, null, null, "user28" },
                    { 29, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(535), null, "user29@mail.com", "User 29", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(535), "cGFzc3dvcmQ=", null, null, null, "user29" },
                    { 30, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(537), null, "user30@mail.com", "User 30", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(538), "cGFzc3dvcmQ=", null, null, null, "user30" },
                    { 31, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(540), null, "user31@mail.com", "User 31", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(540), "cGFzc3dvcmQ=", null, null, null, "user31" },
                    { 32, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(542), null, "user32@mail.com", "User 32", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(543), "cGFzc3dvcmQ=", null, null, null, "user32" },
                    { 33, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(545), null, "user33@mail.com", "User 33", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(545), "cGFzc3dvcmQ=", null, null, null, "user33" },
                    { 34, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(548), null, "user34@mail.com", "User 34", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(548), "cGFzc3dvcmQ=", null, null, null, "user34" },
                    { 35, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(551), null, "user35@mail.com", "User 35", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(551), "cGFzc3dvcmQ=", null, null, null, "user35" },
                    { 36, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(553), null, "user36@mail.com", "User 36", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(554), "cGFzc3dvcmQ=", null, null, null, "user36" },
                    { 37, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(556), null, "user37@mail.com", "User 37", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(556), "cGFzc3dvcmQ=", null, null, null, "user37" },
                    { 38, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(558), null, "user38@mail.com", "User 38", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(559), "cGFzc3dvcmQ=", null, null, null, "user38" },
                    { 39, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(561), null, "user39@mail.com", "User 39", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(561), "cGFzc3dvcmQ=", null, null, null, "user39" },
                    { 40, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(563), null, "user40@mail.com", "User 40", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(564), "cGFzc3dvcmQ=", null, null, null, "user40" },
                    { 41, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(583), null, "user41@mail.com", "User 41", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(584), "cGFzc3dvcmQ=", null, null, null, "user41" },
                    { 42, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(586), null, "user42@mail.com", "User 42", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(586), "cGFzc3dvcmQ=", null, null, null, "user42" },
                    { 43, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(589), null, "user43@mail.com", "User 43", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(589), "cGFzc3dvcmQ=", null, null, null, "user43" },
                    { 44, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(591), null, "user44@mail.com", "User 44", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(592), "cGFzc3dvcmQ=", null, null, null, "user44" },
                    { 45, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(594), null, "user45@mail.com", "User 45", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(594), "cGFzc3dvcmQ=", null, null, null, "user45" },
                    { 46, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(597), null, "user46@mail.com", "User 46", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(597), "cGFzc3dvcmQ=", null, null, null, "user46" },
                    { 47, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(599), null, "user47@mail.com", "User 47", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(600), "cGFzc3dvcmQ=", null, null, null, "user47" },
                    { 48, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(602), null, "user48@mail.com", "User 48", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(602), "cGFzc3dvcmQ=", null, null, null, "user48" },
                    { 49, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(605), null, "user49@mail.com", "User 49", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(605), "cGFzc3dvcmQ=", null, null, null, "user49" },
                    { 50, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(607), null, "user50@mail.com", "User 50", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(608), "cGFzc3dvcmQ=", null, null, null, "user50" },
                    { 51, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(610), null, "user51@mail.com", "User 51", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(610), "cGFzc3dvcmQ=", null, null, null, "user51" },
                    { 52, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(612), null, "user52@mail.com", "User 52", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(613), "cGFzc3dvcmQ=", null, null, null, "user52" },
                    { 53, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(615), null, "user53@mail.com", "User 53", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(615), "cGFzc3dvcmQ=", null, null, null, "user53" },
                    { 54, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(618), null, "user54@mail.com", "User 54", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(618), "cGFzc3dvcmQ=", null, null, null, "user54" },
                    { 55, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(621), null, "user55@mail.com", "User 55", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(621), "cGFzc3dvcmQ=", null, null, null, "user55" },
                    { 56, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(623), null, "user56@mail.com", "User 56", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(623), "cGFzc3dvcmQ=", null, null, null, "user56" },
                    { 57, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(626), null, "user57@mail.com", "User 57", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(626), "cGFzc3dvcmQ=", null, null, null, "user57" },
                    { 58, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(628), null, "user58@mail.com", "User 58", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(629), "cGFzc3dvcmQ=", null, null, null, "user58" },
                    { 59, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(631), null, "user59@mail.com", "User 59", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(631), "cGFzc3dvcmQ=", null, null, null, "user59" },
                    { 60, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(634), null, "user60@mail.com", "User 60", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(634), "cGFzc3dvcmQ=", null, null, null, "user60" },
                    { 61, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(693), null, "user61@mail.com", "User 61", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(693), "cGFzc3dvcmQ=", null, null, null, "user61" },
                    { 62, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(698), null, "user62@mail.com", "User 62", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(698), "cGFzc3dvcmQ=", null, null, null, "user62" },
                    { 63, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(702), null, "user63@mail.com", "User 63", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(703), "cGFzc3dvcmQ=", null, null, null, "user63" },
                    { 64, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(707), null, "user64@mail.com", "User 64", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(707), "cGFzc3dvcmQ=", null, null, null, "user64" },
                    { 65, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(712), null, "user65@mail.com", "User 65", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(712), "cGFzc3dvcmQ=", null, null, null, "user65" },
                    { 66, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(718), null, "user66@mail.com", "User 66", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(718), "cGFzc3dvcmQ=", null, null, null, "user66" },
                    { 67, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(723), null, "user67@mail.com", "User 67", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(723), "cGFzc3dvcmQ=", null, null, null, "user67" },
                    { 68, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(727), null, "user68@mail.com", "User 68", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(727), "cGFzc3dvcmQ=", null, null, null, "user68" },
                    { 69, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(730), null, "user69@mail.com", "User 69", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(730), "cGFzc3dvcmQ=", null, null, null, "user69" },
                    { 70, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(734), null, "user70@mail.com", "User 70", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(734), "cGFzc3dvcmQ=", null, null, null, "user70" },
                    { 71, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(738), null, "user71@mail.com", "User 71", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(738), "cGFzc3dvcmQ=", null, null, null, "user71" },
                    { 72, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(742), null, "user72@mail.com", "User 72", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(742), "cGFzc3dvcmQ=", null, null, null, "user72" },
                    { 73, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(746), null, "user73@mail.com", "User 73", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(747), "cGFzc3dvcmQ=", null, null, null, "user73" },
                    { 74, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(751), null, "user74@mail.com", "User 74", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(751), "cGFzc3dvcmQ=", null, null, null, "user74" },
                    { 75, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(756), null, "user75@mail.com", "User 75", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(756), "cGFzc3dvcmQ=", null, null, null, "user75" },
                    { 76, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(760), null, "user76@mail.com", "User 76", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(760), "cGFzc3dvcmQ=", null, null, null, "user76" },
                    { 77, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(765), null, "user77@mail.com", "User 77", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(765), "cGFzc3dvcmQ=", null, null, null, "user77" },
                    { 78, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(770), null, "user78@mail.com", "User 78", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(770), "cGFzc3dvcmQ=", null, null, null, "user78" },
                    { 79, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(775), null, "user79@mail.com", "User 79", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(775), "cGFzc3dvcmQ=", null, null, null, "user79" },
                    { 80, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(820), null, "user80@mail.com", "User 80", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(820), "cGFzc3dvcmQ=", null, null, null, "user80" },
                    { 81, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(824), null, "user81@mail.com", "User 81", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(824), "cGFzc3dvcmQ=", null, null, null, "user81" },
                    { 82, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(827), null, "user82@mail.com", "User 82", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(828), "cGFzc3dvcmQ=", null, null, null, "user82" },
                    { 83, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(831), null, "user83@mail.com", "User 83", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(831), "cGFzc3dvcmQ=", null, null, null, "user83" },
                    { 84, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(835), null, "user84@mail.com", "User 84", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(835), "cGFzc3dvcmQ=", null, null, null, "user84" },
                    { 85, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(839), null, "user85@mail.com", "User 85", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(839), "cGFzc3dvcmQ=", null, null, null, "user85" },
                    { 86, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(845), null, "user86@mail.com", "User 86", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(845), "cGFzc3dvcmQ=", null, null, null, "user86" },
                    { 87, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(975), null, "user87@mail.com", "User 87", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(976), "cGFzc3dvcmQ=", null, null, null, "user87" },
                    { 88, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(979), null, "user88@mail.com", "User 88", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(980), "cGFzc3dvcmQ=", null, null, null, "user88" },
                    { 89, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(983), null, "user89@mail.com", "User 89", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(983), "cGFzc3dvcmQ=", null, null, null, "user89" },
                    { 90, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(987), null, "user90@mail.com", "User 90", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(987), "cGFzc3dvcmQ=", null, null, null, "user90" },
                    { 91, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(991), null, "user91@mail.com", "User 91", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(991), "cGFzc3dvcmQ=", null, null, null, "user91" },
                    { 92, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(994), null, "user92@mail.com", "User 92", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(994), "cGFzc3dvcmQ=", null, null, null, "user92" },
                    { 93, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(998), null, "user93@mail.com", "User 93", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(999), "cGFzc3dvcmQ=", null, null, null, "user93" },
                    { 94, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1003), null, "user94@mail.com", "User 94", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1003), "cGFzc3dvcmQ=", null, null, null, "user94" },
                    { 95, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1007), null, "user95@mail.com", "User 95", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1007), "cGFzc3dvcmQ=", null, null, null, "user95" },
                    { 96, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1011), null, "user96@mail.com", "User 96", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1011), "cGFzc3dvcmQ=", null, null, null, "user96" },
                    { 97, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1015), null, "user97@mail.com", "User 97", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1015), "cGFzc3dvcmQ=", null, null, null, "user97" },
                    { 98, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1018), null, "user98@mail.com", "User 98", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1018), "cGFzc3dvcmQ=", null, null, null, "user98" },
                    { 99, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1022), null, "user99@mail.com", "User 99", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1022), "cGFzc3dvcmQ=", null, null, null, "user99" },
                    { 100, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1057), null, "user100@mail.com", "User 100", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1057), "cGFzc3dvcmQ=", null, null, null, "user100" },
                    { 101, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1061), null, "user101@mail.com", "User 101", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1062), "cGFzc3dvcmQ=", null, null, null, "user101" },
                    { 102, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1067), null, "user102@mail.com", "User 102", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1067), "cGFzc3dvcmQ=", null, null, null, "user102" },
                    { 103, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1071), null, "user103@mail.com", "User 103", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1071), "cGFzc3dvcmQ=", null, null, null, "user103" },
                    { 104, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1076), null, "user104@mail.com", "User 104", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1076), "cGFzc3dvcmQ=", null, null, null, "user104" },
                    { 105, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1081), null, "user105@mail.com", "User 105", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1081), "cGFzc3dvcmQ=", null, null, null, "user105" },
                    { 106, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1086), null, "user106@mail.com", "User 106", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1086), "cGFzc3dvcmQ=", null, null, null, "user106" },
                    { 107, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1090), null, "user107@mail.com", "User 107", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1090), "cGFzc3dvcmQ=", null, null, null, "user107" },
                    { 108, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1093), null, "user108@mail.com", "User 108", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1094), "cGFzc3dvcmQ=", null, null, null, "user108" },
                    { 109, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1097), null, "user109@mail.com", "User 109", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1099), "cGFzc3dvcmQ=", null, null, null, "user109" },
                    { 110, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1102), null, "user110@mail.com", "User 110", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1103), "cGFzc3dvcmQ=", null, null, null, "user110" },
                    { 111, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1106), null, "user111@mail.com", "User 111", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1107), "cGFzc3dvcmQ=", null, null, null, "user111" },
                    { 112, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1110), null, "user112@mail.com", "User 112", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1110), "cGFzc3dvcmQ=", null, null, null, "user112" },
                    { 113, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1113), null, "user113@mail.com", "User 113", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1114), "cGFzc3dvcmQ=", null, null, null, "user113" },
                    { 114, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1117), null, "user114@mail.com", "User 114", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1117), "cGFzc3dvcmQ=", null, null, null, "user114" },
                    { 115, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1121), null, "user115@mail.com", "User 115", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1121), "cGFzc3dvcmQ=", null, null, null, "user115" },
                    { 116, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1124), null, "user116@mail.com", "User 116", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1124), "cGFzc3dvcmQ=", null, null, null, "user116" },
                    { 117, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1127), null, "user117@mail.com", "User 117", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1128), "cGFzc3dvcmQ=", null, null, null, "user117" },
                    { 118, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1131), null, "user118@mail.com", "User 118", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1131), "cGFzc3dvcmQ=", null, null, null, "user118" },
                    { 119, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1134), null, "user119@mail.com", "User 119", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1135), "cGFzc3dvcmQ=", null, null, null, "user119" },
                    { 120, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1138), null, "user120@mail.com", "User 120", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1138), "cGFzc3dvcmQ=", null, null, null, "user120" },
                    { 121, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1184), null, "user121@mail.com", "User 121", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1184), "cGFzc3dvcmQ=", null, null, null, "user121" },
                    { 122, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1189), null, "user122@mail.com", "User 122", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1190), "cGFzc3dvcmQ=", null, null, null, "user122" },
                    { 123, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1195), null, "user123@mail.com", "User 123", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1195), "cGFzc3dvcmQ=", null, null, null, "user123" },
                    { 124, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1273), null, "user124@mail.com", "User 124", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1273), "cGFzc3dvcmQ=", null, null, null, "user124" },
                    { 125, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1277), null, "user125@mail.com", "User 125", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1277), "cGFzc3dvcmQ=", null, null, null, "user125" },
                    { 126, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1282), null, "user126@mail.com", "User 126", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1282), "cGFzc3dvcmQ=", null, null, null, "user126" },
                    { 127, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1337), null, "user127@mail.com", "User 127", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1337), "cGFzc3dvcmQ=", null, null, null, "user127" },
                    { 128, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1340), null, "user128@mail.com", "User 128", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1340), "cGFzc3dvcmQ=", null, null, null, "user128" },
                    { 129, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1343), null, "user129@mail.com", "User 129", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1343), "cGFzc3dvcmQ=", null, null, null, "user129" },
                    { 130, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1348), null, "user130@mail.com", "User 130", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1348), "cGFzc3dvcmQ=", null, null, null, "user130" },
                    { 131, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1354), null, "user131@mail.com", "User 131", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1354), "cGFzc3dvcmQ=", null, null, null, "user131" },
                    { 132, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1358), null, "user132@mail.com", "User 132", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1359), "cGFzc3dvcmQ=", null, null, null, "user132" },
                    { 133, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1363), null, "user133@mail.com", "User 133", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1364), "cGFzc3dvcmQ=", null, null, null, "user133" },
                    { 134, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1368), null, "user134@mail.com", "User 134", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1369), "cGFzc3dvcmQ=", null, null, null, "user134" },
                    { 135, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1373), null, "user135@mail.com", "User 135", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1373), "cGFzc3dvcmQ=", null, null, null, "user135" },
                    { 136, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1378), null, "user136@mail.com", "User 136", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1378), "cGFzc3dvcmQ=", null, null, null, "user136" },
                    { 137, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1420), null, "user137@mail.com", "User 137", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1420), "cGFzc3dvcmQ=", null, null, null, "user137" },
                    { 138, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1424), null, "user138@mail.com", "User 138", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1425), "cGFzc3dvcmQ=", null, null, null, "user138" },
                    { 139, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1429), null, "user139@mail.com", "User 139", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1429), "cGFzc3dvcmQ=", null, null, null, "user139" },
                    { 140, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1433), null, "user140@mail.com", "User 140", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1433), "cGFzc3dvcmQ=", null, null, null, "user140" },
                    { 141, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1436), null, "user141@mail.com", "User 141", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1437), "cGFzc3dvcmQ=", null, null, null, "user141" },
                    { 142, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1440), null, "user142@mail.com", "User 142", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1440), "cGFzc3dvcmQ=", null, null, null, "user142" },
                    { 143, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1443), null, "user143@mail.com", "User 143", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1444), "cGFzc3dvcmQ=", null, null, null, "user143" },
                    { 144, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1447), null, "user144@mail.com", "User 144", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1447), "cGFzc3dvcmQ=", null, null, null, "user144" },
                    { 145, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1451), null, "user145@mail.com", "User 145", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1451), "cGFzc3dvcmQ=", null, null, null, "user145" },
                    { 146, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1455), null, "user146@mail.com", "User 146", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1455), "cGFzc3dvcmQ=", null, null, null, "user146" },
                    { 147, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1458), null, "user147@mail.com", "User 147", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1459), "cGFzc3dvcmQ=", null, null, null, "user147" },
                    { 148, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1462), null, "user148@mail.com", "User 148", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1463), "cGFzc3dvcmQ=", null, null, null, "user148" },
                    { 149, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1466), null, "user149@mail.com", "User 149", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1466), "cGFzc3dvcmQ=", null, null, null, "user149" },
                    { 150, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1470), null, "user150@mail.com", "User 150", true, false, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(1470), "cGFzc3dvcmQ=", null, null, null, "user150" }
                });

            migrationBuilder.InsertData(
                schema: "Training",
                table: "Branch",
                columns: new[] { "BranchID", "Address", "BankID", "BranchName", "City", "ContactNumber", "CreatedDate", "IFSCCode", "IsActive" },
                values: new object[,]
                {
                    { 1, "Address 1", 1, "Branch 1", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5746), null, true },
                    { 2, "Address 2", 1, "Branch 2", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5899), null, true },
                    { 3, "Address 3", 1, "Branch 3", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5901), null, true },
                    { 4, "Address 4", 1, "Branch 4", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5943), null, true },
                    { 5, "Address 5", 1, "Branch 5", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5945), null, true },
                    { 6, "Address 6", 1, "Branch 6", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5949), null, true },
                    { 7, "Address 7", 1, "Branch 7", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5951), null, true },
                    { 8, "Address 8", 1, "Branch 8", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5953), null, true },
                    { 9, "Address 9", 1, "Branch 9", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5954), null, true },
                    { 10, "Address 10", 1, "Branch 10", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5957), null, true },
                    { 11, "Address 11", 2, "Branch 11", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5959), null, true },
                    { 12, "Address 12", 2, "Branch 12", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5961), null, true },
                    { 13, "Address 13", 2, "Branch 13", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5962), null, true },
                    { 14, "Address 14", 2, "Branch 14", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5963), null, true },
                    { 15, "Address 15", 2, "Branch 15", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5964), null, true },
                    { 16, "Address 16", 2, "Branch 16", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5966), null, true },
                    { 17, "Address 17", 2, "Branch 17", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5967), null, true },
                    { 18, "Address 18", 2, "Branch 18", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5969), null, true },
                    { 19, "Address 19", 2, "Branch 19", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5970), null, true },
                    { 20, "Address 20", 2, "Branch 20", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5971), null, true },
                    { 21, "Address 21", 3, "Branch 21", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5972), null, true },
                    { 22, "Address 22", 3, "Branch 22", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5974), null, true },
                    { 23, "Address 23", 3, "Branch 23", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5975), null, true },
                    { 24, "Address 24", 3, "Branch 24", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5976), null, true },
                    { 25, "Address 25", 3, "Branch 25", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5977), null, true },
                    { 26, "Address 26", 3, "Branch 26", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5978), null, true },
                    { 27, "Address 27", 3, "Branch 27", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5980), null, true },
                    { 28, "Address 28", 3, "Branch 28", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5981), null, true },
                    { 29, "Address 29", 3, "Branch 29", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5982), null, true },
                    { 30, "Address 30", 3, "Branch 30", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5983), null, true },
                    { 31, "Address 31", 4, "Branch 31", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5984), null, true },
                    { 32, "Address 32", 4, "Branch 32", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5986), null, true },
                    { 33, "Address 33", 4, "Branch 33", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(5987), null, true },
                    { 34, "Address 34", 4, "Branch 34", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6013), null, true },
                    { 35, "Address 35", 4, "Branch 35", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6014), null, true },
                    { 36, "Address 36", 4, "Branch 36", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6016), null, true },
                    { 37, "Address 37", 4, "Branch 37", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6017), null, true },
                    { 38, "Address 38", 4, "Branch 38", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6019), null, true },
                    { 39, "Address 39", 4, "Branch 39", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6020), null, true },
                    { 40, "Address 40", 4, "Branch 40", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6021), null, true },
                    { 41, "Address 41", 5, "Branch 41", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6023), null, true },
                    { 42, "Address 42", 5, "Branch 42", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6024), null, true },
                    { 43, "Address 43", 5, "Branch 43", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6025), null, true },
                    { 44, "Address 44", 5, "Branch 44", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6026), null, true },
                    { 45, "Address 45", 5, "Branch 45", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6027), null, true },
                    { 46, "Address 46", 5, "Branch 46", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6028), null, true },
                    { 47, "Address 47", 5, "Branch 47", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6030), null, true },
                    { 48, "Address 48", 5, "Branch 48", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6031), null, true },
                    { 49, "Address 49", 5, "Branch 49", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6032), null, true },
                    { 50, "Address 50", 5, "Branch 50", null, null, new DateTime(2025, 11, 18, 6, 9, 34, 655, DateTimeKind.Utc).AddTicks(6033), null, true }
                });

            migrationBuilder.InsertData(
                schema: "Training",
                table: "Account",
                columns: new[] { "AccountID", "AccountNumber", "AccountTypeID", "Balance", "BankID", "BranchID", "CloseDate", "CreatedDate", "CurrencyCode", "IsActive", "ModifiedDate", "OpenDate", "UserID" },
                values: new object[,]
                {
                    { 1, "ACCT-100001", 2, 5010m, 1, 1, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6554), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6695), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6167), 1 },
                    { 2, "ACCT-100002", 3, 5020m, 1, 2, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6865), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6865), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6864), 2 },
                    { 3, "ACCT-100003", 1, 5030m, 1, 3, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6869), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6869), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6869), 3 },
                    { 4, "ACCT-100004", 2, 5040m, 1, 4, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6872), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6872), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6871), 4 },
                    { 5, "ACCT-100005", 3, 5050m, 1, 5, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6875), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6875), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6874), 5 },
                    { 6, "ACCT-100006", 1, 5060m, 1, 6, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6886), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6886), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6886), 6 },
                    { 7, "ACCT-100007", 2, 5070m, 1, 7, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6889), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6890), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6889), 7 },
                    { 8, "ACCT-100008", 3, 5080m, 1, 8, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6892), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6892), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6892), 8 },
                    { 9, "ACCT-100009", 1, 5090m, 1, 9, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6895), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6895), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6895), 9 },
                    { 10, "ACCT-100010", 2, 5100m, 1, 10, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6898), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6899), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6898), 10 },
                    { 11, "ACCT-100011", 3, 5110m, 1, 1, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6901), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6901), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6900), 11 },
                    { 12, "ACCT-100012", 1, 5120m, 1, 2, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6904), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6904), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6903), 12 },
                    { 13, "ACCT-100013", 2, 5130m, 1, 3, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6906), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6906), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6906), 13 },
                    { 14, "ACCT-100014", 3, 5140m, 1, 4, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6909), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6909), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6909), 14 },
                    { 15, "ACCT-100015", 1, 5150m, 1, 5, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6911), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6912), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6911), 15 },
                    { 16, "ACCT-100016", 2, 5160m, 1, 6, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6914), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6914), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6914), 16 },
                    { 17, "ACCT-100017", 3, 5170m, 1, 7, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6916), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6917), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6916), 17 },
                    { 18, "ACCT-100018", 1, 5180m, 1, 8, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6920), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6920), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6920), 18 },
                    { 19, "ACCT-100019", 2, 5190m, 1, 9, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6922), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6922), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6922), 19 },
                    { 20, "ACCT-100020", 3, 5200m, 1, 10, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6924), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6925), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6924), 20 },
                    { 21, "ACCT-100021", 1, 5210m, 1, 1, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6927), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6928), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6927), 21 },
                    { 22, "ACCT-100022", 2, 5220m, 1, 2, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6930), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6931), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6930), 22 },
                    { 23, "ACCT-100023", 3, 5230m, 1, 3, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6933), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6933), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6932), 23 },
                    { 24, "ACCT-100024", 1, 5240m, 1, 4, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6935), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6935), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6935), 24 },
                    { 25, "ACCT-100025", 2, 5250m, 1, 5, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6938), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6938), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6938), 25 },
                    { 26, "ACCT-100026", 3, 5260m, 1, 6, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6940), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6941), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6940), 26 },
                    { 27, "ACCT-100027", 1, 5270m, 1, 7, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6943), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6944), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6943), 27 },
                    { 28, "ACCT-100028", 2, 5280m, 1, 8, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6946), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6946), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6946), 28 },
                    { 29, "ACCT-100029", 3, 5290m, 1, 9, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6948), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6949), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6948), 29 },
                    { 30, "ACCT-100030", 1, 5300m, 1, 10, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6951), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6951), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(6951), 30 },
                    { 31, "ACCT-100031", 2, 5310m, 2, 11, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7009), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7009), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7009), 31 },
                    { 32, "ACCT-100032", 3, 5320m, 2, 12, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7012), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7012), 32 },
                    { 33, "ACCT-100033", 1, 5330m, 2, 13, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7014), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7015), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7014), 33 },
                    { 34, "ACCT-100034", 2, 5340m, 2, 14, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7018), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7019), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7018), 34 },
                    { 35, "ACCT-100035", 3, 5350m, 2, 15, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7021), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7021), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7020), 35 },
                    { 36, "ACCT-100036", 1, 5360m, 2, 16, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7023), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7023), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7023), 36 },
                    { 37, "ACCT-100037", 2, 5370m, 2, 17, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7026), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7026), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7026), 37 },
                    { 38, "ACCT-100038", 3, 5380m, 2, 18, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7028), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7028), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7028), 38 },
                    { 39, "ACCT-100039", 1, 5390m, 2, 19, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7031), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7031), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7031), 39 },
                    { 40, "ACCT-100040", 2, 5400m, 2, 20, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7034), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7034), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7034), 40 },
                    { 41, "ACCT-100041", 3, 5410m, 2, 11, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7036), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7037), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7036), 41 },
                    { 42, "ACCT-100042", 1, 5420m, 2, 12, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7039), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7039), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7038), 42 },
                    { 43, "ACCT-100043", 2, 5430m, 2, 13, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7041), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7042), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7041), 43 },
                    { 44, "ACCT-100044", 3, 5440m, 2, 14, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7044), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7045), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7044), 44 },
                    { 45, "ACCT-100045", 1, 5450m, 2, 15, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7047), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7047), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7046), 45 },
                    { 46, "ACCT-100046", 2, 5460m, 2, 16, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7049), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7049), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7049), 46 },
                    { 47, "ACCT-100047", 3, 5470m, 2, 17, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7052), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7052), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7052), 47 },
                    { 48, "ACCT-100048", 1, 5480m, 2, 18, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7056), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7056), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7055), 48 },
                    { 49, "ACCT-100049", 2, 5490m, 2, 19, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7059), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7059), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7058), 49 },
                    { 50, "ACCT-100050", 3, 5500m, 2, 20, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7061), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7061), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7061), 50 },
                    { 51, "ACCT-100051", 1, 5510m, 2, 11, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7064), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7064), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7064), 51 },
                    { 52, "ACCT-100052", 2, 5520m, 2, 12, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7068), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7068), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7067), 52 },
                    { 53, "ACCT-100053", 3, 5530m, 2, 13, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7070), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7070), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7070), 53 },
                    { 54, "ACCT-100054", 1, 5540m, 2, 14, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7073), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7073), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7073), 54 },
                    { 55, "ACCT-100055", 2, 5550m, 2, 15, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7076), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7076), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7075), 55 },
                    { 56, "ACCT-100056", 3, 5560m, 2, 16, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7078), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7078), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7078), 56 },
                    { 57, "ACCT-100057", 1, 5570m, 2, 17, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7080), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7081), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7080), 57 },
                    { 58, "ACCT-100058", 2, 5580m, 2, 18, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7083), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7083), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7082), 58 },
                    { 59, "ACCT-100059", 3, 5590m, 2, 19, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7085), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7086), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7085), 59 },
                    { 60, "ACCT-100060", 1, 5600m, 2, 20, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7088), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7088), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7088), 60 },
                    { 61, "ACCT-100061", 2, 5610m, 3, 21, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7091), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7091), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7090), 61 },
                    { 62, "ACCT-100062", 3, 5620m, 3, 22, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7093), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7093), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7093), 62 },
                    { 63, "ACCT-100063", 1, 5630m, 3, 23, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7096), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7096), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7096), 63 },
                    { 64, "ACCT-100064", 2, 5640m, 3, 24, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7099), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7099), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7099), 64 },
                    { 65, "ACCT-100065", 3, 5650m, 3, 25, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7102), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7102), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7101), 65 },
                    { 66, "ACCT-100066", 1, 5660m, 3, 26, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7128), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7128), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7127), 66 },
                    { 67, "ACCT-100067", 2, 5670m, 3, 27, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7130), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7130), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7130), 67 },
                    { 68, "ACCT-100068", 3, 5680m, 3, 28, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7133), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7133), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7132), 68 },
                    { 69, "ACCT-100069", 1, 5690m, 3, 29, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7135), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7135), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7134), 69 },
                    { 70, "ACCT-100070", 2, 5700m, 3, 30, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7138), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7138), 70 },
                    { 71, "ACCT-100071", 3, 5710m, 3, 21, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7140), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7140), 71 },
                    { 72, "ACCT-100072", 1, 5720m, 3, 22, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7143), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7143), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7142), 72 },
                    { 73, "ACCT-100073", 2, 5730m, 3, 23, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7145), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7145), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7145), 73 },
                    { 74, "ACCT-100074", 3, 5740m, 3, 24, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7147), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7148), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7147), 74 },
                    { 75, "ACCT-100075", 1, 5750m, 3, 25, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7150), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7150), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7149), 75 },
                    { 76, "ACCT-100076", 2, 5760m, 3, 26, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7152), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7152), 76 },
                    { 77, "ACCT-100077", 3, 5770m, 3, 27, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7155), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7155), 77 },
                    { 78, "ACCT-100078", 1, 5780m, 3, 28, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7158), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7158), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7158), 78 },
                    { 79, "ACCT-100079", 2, 5790m, 3, 29, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7160), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7160), 79 },
                    { 80, "ACCT-100080", 3, 5800m, 3, 30, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7163), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7163), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7163), 80 },
                    { 81, "ACCT-100081", 1, 5810m, 3, 21, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7166), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7165), 81 },
                    { 82, "ACCT-100082", 2, 5820m, 3, 22, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7168), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7168), 82 },
                    { 83, "ACCT-100083", 3, 5830m, 3, 23, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7171), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7170), 83 },
                    { 84, "ACCT-100084", 1, 5840m, 3, 24, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7173), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7173), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7173), 84 },
                    { 85, "ACCT-100085", 2, 5850m, 3, 25, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7176), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7176), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7175), 85 },
                    { 86, "ACCT-100086", 3, 5860m, 3, 26, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7179), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7179), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7178), 86 },
                    { 87, "ACCT-100087", 1, 5870m, 3, 27, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7181), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7181), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7181), 87 },
                    { 88, "ACCT-100088", 2, 5880m, 3, 28, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7184), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7184), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7183), 88 },
                    { 89, "ACCT-100089", 3, 5890m, 3, 29, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7186), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7186), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7186), 89 },
                    { 90, "ACCT-100090", 1, 5900m, 3, 30, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7189), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7189), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7188), 90 },
                    { 91, "ACCT-100091", 2, 5910m, 4, 31, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7193), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7193), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7192), 91 },
                    { 92, "ACCT-100092", 3, 5920m, 4, 32, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7195), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7196), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7195), 92 },
                    { 93, "ACCT-100093", 1, 5930m, 4, 33, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7198), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7198), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7197), 93 },
                    { 94, "ACCT-100094", 2, 5940m, 4, 34, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7200), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7200), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7200), 94 },
                    { 95, "ACCT-100095", 3, 5950m, 4, 35, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7202), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7203), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7202), 95 },
                    { 96, "ACCT-100096", 1, 5960m, 4, 36, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7205), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7204), 96 },
                    { 97, "ACCT-100097", 2, 5970m, 4, 37, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7207), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7207), 97 },
                    { 98, "ACCT-100098", 3, 5980m, 4, 38, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7209), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7209), 98 },
                    { 99, "ACCT-100099", 1, 5990m, 4, 39, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7212), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7212), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7212), 99 },
                    { 100, "ACCT-100100", 2, 6000m, 4, 40, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7214), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7215), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7214), 100 },
                    { 101, "ACCT-100101", 3, 6010m, 4, 31, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7217), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7217), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7217), 101 },
                    { 102, "ACCT-100102", 1, 6020m, 4, 32, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7220), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7219), 102 },
                    { 103, "ACCT-100103", 2, 6030m, 4, 33, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7280), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7280), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7279), 103 },
                    { 104, "ACCT-100104", 3, 6040m, 4, 34, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7282), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7282), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7282), 104 },
                    { 105, "ACCT-100105", 1, 6050m, 4, 35, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7285), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7285), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7284), 105 },
                    { 106, "ACCT-100106", 2, 6060m, 4, 36, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7287), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7287), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7287), 106 },
                    { 107, "ACCT-100107", 3, 6070m, 4, 37, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7290), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7290), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7289), 107 },
                    { 108, "ACCT-100108", 1, 6080m, 4, 38, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7292), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7292), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7292), 108 },
                    { 109, "ACCT-100109", 2, 6090m, 4, 39, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7295), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7295), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7295), 109 },
                    { 110, "ACCT-100110", 3, 6100m, 4, 40, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7298), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7298), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7297), 110 },
                    { 111, "ACCT-100111", 1, 6110m, 4, 31, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7300), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7300), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7300), 111 },
                    { 112, "ACCT-100112", 2, 6120m, 4, 32, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7303), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7302), 112 },
                    { 113, "ACCT-100113", 3, 6130m, 4, 33, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7305), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7305), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7305), 113 },
                    { 114, "ACCT-100114", 1, 6140m, 4, 34, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7308), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7307), 114 },
                    { 115, "ACCT-100115", 2, 6150m, 4, 35, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7310), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7311), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7310), 115 },
                    { 116, "ACCT-100116", 3, 6160m, 4, 36, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7313), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7312), 116 },
                    { 117, "ACCT-100117", 1, 6170m, 4, 37, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7315), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7315), 117 },
                    { 118, "ACCT-100118", 2, 6180m, 4, 38, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7318), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7317), 118 },
                    { 119, "ACCT-100119", 3, 6190m, 4, 39, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7320), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7319), 119 },
                    { 120, "ACCT-100120", 1, 6200m, 4, 40, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7322), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7322), 120 },
                    { 121, "ACCT-100121", 2, 6210m, 5, 41, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7325), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7324), 121 },
                    { 122, "ACCT-100122", 3, 6220m, 5, 42, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7327), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7327), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7327), 122 },
                    { 123, "ACCT-100123", 1, 6230m, 5, 43, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7330), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7330), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7330), 123 },
                    { 124, "ACCT-100124", 2, 6240m, 5, 44, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7332), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7332), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7332), 124 },
                    { 125, "ACCT-100125", 3, 6250m, 5, 45, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7335), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7334), 125 },
                    { 126, "ACCT-100126", 1, 6260m, 5, 46, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7337), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7337), 126 },
                    { 127, "ACCT-100127", 2, 6270m, 5, 47, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7340), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7340), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7339), 127 },
                    { 128, "ACCT-100128", 3, 6280m, 5, 48, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7342), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7343), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7342), 128 },
                    { 129, "ACCT-100129", 1, 6290m, 5, 49, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7345), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7345), 129 },
                    { 130, "ACCT-100130", 2, 6300m, 5, 50, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7350), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7350), 130 },
                    { 131, "ACCT-100131", 3, 6310m, 5, 41, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7353), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7353), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7353), 131 },
                    { 132, "ACCT-100132", 1, 6320m, 5, 42, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7356), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7355), 132 },
                    { 133, "ACCT-100133", 2, 6330m, 5, 43, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7358), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7358), 133 },
                    { 134, "ACCT-100134", 3, 6340m, 5, 44, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7397), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7398), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7397), 134 },
                    { 135, "ACCT-100135", 1, 6350m, 5, 45, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7400), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7400), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7400), 135 },
                    { 136, "ACCT-100136", 2, 6360m, 5, 46, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7403), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7403), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7403), 136 },
                    { 137, "ACCT-100137", 3, 6370m, 5, 47, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7405), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7406), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7405), 137 },
                    { 138, "ACCT-100138", 1, 6380m, 5, 48, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7408), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7409), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7408), 138 },
                    { 139, "ACCT-100139", 2, 6390m, 5, 49, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7411), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7411), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7410), 139 },
                    { 140, "ACCT-100140", 3, 6400m, 5, 50, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7413), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7413), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7413), 140 },
                    { 141, "ACCT-100141", 1, 6410m, 5, 41, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7415), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7416), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7415), 141 },
                    { 142, "ACCT-100142", 2, 6420m, 5, 42, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7418), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7419), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7418), 142 },
                    { 143, "ACCT-100143", 3, 6430m, 5, 43, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7421), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7421), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7421), 143 },
                    { 144, "ACCT-100144", 1, 6440m, 5, 44, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7424), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7424), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7424), 144 },
                    { 145, "ACCT-100145", 2, 6450m, 5, 45, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7426), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7426), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7426), 145 },
                    { 146, "ACCT-100146", 3, 6460m, 5, 46, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7429), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7429), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7429), 146 },
                    { 147, "ACCT-100147", 1, 6470m, 5, 47, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7432), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7432), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7432), 147 },
                    { 148, "ACCT-100148", 2, 6480m, 5, 48, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7434), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7434), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7434), 148 },
                    { 149, "ACCT-100149", 3, 6490m, 5, 49, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7437), "USD", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7437), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7437), 149 },
                    { 150, "ACCT-100150", 1, 6500m, 5, 50, null, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7440), "INR", true, new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7440), new DateTime(2025, 11, 18, 6, 9, 34, 658, DateTimeKind.Utc).AddTicks(7439), 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Account",
                keyColumn: "AccountID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Currency",
                keyColumn: "CurrencyCode",
                keyValue: "EUR");

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "AccountType",
                keyColumn: "AccountTypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "AccountType",
                keyColumn: "AccountTypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "AccountType",
                keyColumn: "AccountTypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Branch",
                keyColumn: "BranchID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Currency",
                keyColumn: "CurrencyCode",
                keyValue: "INR");

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Currency",
                keyColumn: "CurrencyCode",
                keyValue: "USD");

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "User",
                keyColumn: "UserID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Bank",
                keyColumn: "BankID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Bank",
                keyColumn: "BankID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Bank",
                keyColumn: "BankID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Bank",
                keyColumn: "BankID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "Training",
                table: "Bank",
                keyColumn: "BankID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Training",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "Training",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                schema: "Training",
                table: "Bank");
        }
    }
}
