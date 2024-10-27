using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class User : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 27, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "Password", "Role" },
                values: new object[] { 3, "admin@info.com", "Admin", "password567", "Admin" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 17, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 7, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 22, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 24, 15, 41, 53, 208, DateTimeKind.Local).AddTicks(9088));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 23, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 13, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 3, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 18, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 22, 2, 45, 767, DateTimeKind.Local).AddTicks(1440));
        }
    }
}
