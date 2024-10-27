using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InfoSystem.Migrations
{
    /// <inheritdoc />
    public partial class Initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarReg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponsibleEmployee = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalBeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BeloppUt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeloppIn = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventID);
                    table.ForeignKey(
                        name: "FK_Events_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "DriverID", "BeloppIn", "BeloppUt", "CarReg", "DriverName", "NoteDate", "NoteDescription", "ResponsibleEmployee", "TotalBeloppIn", "TotalBeloppUt" },
                values: new object[,]
                {
                    { 1, 0m, 100m, "ABC123", "Emma Nilsson", new DateTime(2024, 8, 22, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7459), "Added to System", "Alice Johnson", 0m, 100m },
                    { 2, 0m, 150m, "XYZ987", "Per Karlsson", new DateTime(2024, 9, 22, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7546), "Added to System", "Bob Smith", 0m, 150m },
                    { 3, 150m, 0m, "ATZ127", "Olle Persson", new DateTime(2024, 9, 22, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7553), "Added to System", "Bob Smith", 150m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "Name", "Password", "Role" },
                values: new object[,]
                {
                    { 1, "alice@info.com", "Alice Johnson", "password123", "Employee" },
                    { 2, "bob@info.com", "Bob Smith", "password234", "Employee" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventID", "BeloppIn", "BeloppUt", "DriverID", "NoteDate", "NoteDescription" },
                values: new object[,]
                {
                    { 1, 0m, 100m, 1, new DateTime(2024, 10, 12, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7589), "Speeding violation" },
                    { 2, 0m, 50m, 1, new DateTime(2024, 10, 2, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7597), "Routine maintenance" },
                    { 3, 0m, 100m, 2, new DateTime(2024, 10, 17, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7601), "Tire replacement" },
                    { 4, 150m, 0m, 3, new DateTime(2024, 10, 19, 11, 27, 29, 654, DateTimeKind.Local).AddTicks(7606), "Package deliverd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_DriverID",
                table: "Events",
                column: "DriverID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Drivers");
        }
    }
}
