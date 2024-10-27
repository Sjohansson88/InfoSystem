using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Newclass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 23, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 13, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 3, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 18, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 11, 58, 3, 345, DateTimeKind.Local).AddTicks(9924));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 23, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 23, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 13, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 3, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 18, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 11, 27, 20, 536, DateTimeKind.Local).AddTicks(3720));
        }
    }
}
