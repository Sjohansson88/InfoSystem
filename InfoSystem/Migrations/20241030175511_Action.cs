using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Action : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionType",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 8, 30, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 9, 30, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 3,
                columns: new[] { "ActionType", "NoteDate" },
                values: new object[] { null, new DateTime(2024, 9, 30, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 10, 20, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 10, 10, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 3,
                column: "NoteDate",
                value: new DateTime(2024, 10, 25, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventID",
                keyValue: 4,
                column: "NoteDate",
                value: new DateTime(2024, 10, 27, 18, 55, 10, 82, DateTimeKind.Local).AddTicks(3440));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionType",
                table: "Drivers");

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 1,
                column: "NoteDate",
                value: new DateTime(2024, 8, 30, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "Drivers",
                keyColumn: "DriverID",
                keyValue: 2,
                column: "NoteDate",
                value: new DateTime(2024, 9, 30, 18, 35, 44, 580, DateTimeKind.Local).AddTicks(3399));

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
    }
}
