using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Azure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 30, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 10, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 25, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 27, 17, 19, 19, 990, DateTimeKind.Local).AddTicks(3523));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 17, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 7, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 22, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 24, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1895));
        }
    }
}
