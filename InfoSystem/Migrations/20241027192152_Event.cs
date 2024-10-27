using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Event : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionType",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 10, 17, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 10, 7, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 10, 22, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 10, 24, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1895) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionType",
                table: "Events");

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
    }
}
