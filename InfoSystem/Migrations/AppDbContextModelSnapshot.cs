﻿// <auto-generated />
using System;
using InfoSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InfoSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InfoSystem.Models.Driver", b =>
                {
                    b.Property<int>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverID"));

                    b.Property<decimal>("BeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("CarReg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponsibleEmployee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalBeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("TotalBeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("DriverID");

                    b.ToTable("Drivers");

                    b.HasData(
                        new
                        {
                            DriverID = 1,
                            BeloppIn = 0m,
                            BeloppUt = 100m,
                            CarReg = "ABC123",
                            DriverName = "Emma Nilsson",
                            NoteDate = new DateTime(2024, 8, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1722),
                            NoteDescription = "Added to System",
                            ResponsibleEmployee = "Alice Johnson",
                            TotalBeloppIn = 0m,
                            TotalBeloppUt = 100m
                        },
                        new
                        {
                            DriverID = 2,
                            BeloppIn = 0m,
                            BeloppUt = 150m,
                            CarReg = "XYZ987",
                            DriverName = "Per Karlsson",
                            NoteDate = new DateTime(2024, 9, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1812),
                            NoteDescription = "Added to System",
                            ResponsibleEmployee = "Bob Smith",
                            TotalBeloppIn = 0m,
                            TotalBeloppUt = 150m
                        },
                        new
                        {
                            DriverID = 3,
                            BeloppIn = 150m,
                            BeloppUt = 0m,
                            CarReg = "ATZ127",
                            DriverName = "Olle Persson",
                            NoteDate = new DateTime(2024, 9, 27, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1822),
                            NoteDescription = "Added to System",
                            ResponsibleEmployee = "Bob Smith",
                            TotalBeloppIn = 150m,
                            TotalBeloppUt = 0m
                        });
                });

            modelBuilder.Entity("InfoSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            Email = "alice@info.com",
                            Name = "Alice Johnson",
                            Password = "password123",
                            Role = "Employee"
                        },
                        new
                        {
                            EmployeeId = 2,
                            Email = "bob@info.com",
                            Name = "Bob Smith",
                            Password = "password234",
                            Role = "Employee"
                        },
                        new
                        {
                            EmployeeId = 3,
                            Email = "admin@info.com",
                            Name = "Admin",
                            Password = "password567",
                            Role = "Admin"
                        });
                });

            modelBuilder.Entity("InfoSystem.Models.Event", b =>
                {
                    b.Property<int>("EventID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EventID"));

                    b.Property<string>("ActionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BeloppIn")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("BeloppUt")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DriverID")
                        .HasColumnType("int");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EventID");

                    b.HasIndex("DriverID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventID = 1,
                            BeloppIn = 0m,
                            BeloppUt = 100m,
                            DriverID = 1,
                            NoteDate = new DateTime(2024, 10, 17, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1868),
                            NoteDescription = "Speeding violation"
                        },
                        new
                        {
                            EventID = 2,
                            BeloppIn = 0m,
                            BeloppUt = 50m,
                            DriverID = 1,
                            NoteDate = new DateTime(2024, 10, 7, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1881),
                            NoteDescription = "Routine maintenance"
                        },
                        new
                        {
                            EventID = 3,
                            BeloppIn = 0m,
                            BeloppUt = 100m,
                            DriverID = 2,
                            NoteDate = new DateTime(2024, 10, 22, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1889),
                            NoteDescription = "Tire replacement"
                        },
                        new
                        {
                            EventID = 4,
                            BeloppIn = 150m,
                            BeloppUt = 0m,
                            DriverID = 3,
                            NoteDate = new DateTime(2024, 10, 24, 20, 21, 49, 964, DateTimeKind.Local).AddTicks(1895),
                            NoteDescription = "Package deliverd"
                        });
                });

            modelBuilder.Entity("InfoSystem.Models.Event", b =>
                {
                    b.HasOne("InfoSystem.Models.Driver", "Driver")
                        .WithMany("Events")
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("InfoSystem.Models.Driver", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
