using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Azure2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "BeloppUt", "NoteDate", "TotalBeloppUt" },
                values: new object[] { 150m, new DateTime(2024, 8, 30, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3321), 150m });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "BeloppUt", "NoteDate" },
                values: new object[] { 100m, new DateTime(2024, 9, 30, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 10, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 25, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 27, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3454));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "BeloppUt", "NoteDate", "TotalBeloppUt" },
                values: new object[] { 100m, new DateTime(2024, 8, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1722), 100m });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "BeloppUt", "NoteDate" },
                values: new object[] { 150m, new DateTime(2024, 9, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1812) });

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
