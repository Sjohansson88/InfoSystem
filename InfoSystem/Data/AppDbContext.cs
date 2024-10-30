using InfoSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace InfoSystem.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

		public DbSet<Driver> Drivers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Event> Events { get; set; }




		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			
			modelBuilder.Entity<Employee>().HasData(
				new Employee { EmployeeId = 1, Name = "Alice Johnson", Email = "alice@info.com", Password = "password123", Role = "Employee" },
				new Employee { EmployeeId = 2, Name = "Bob Smith", Email = "bob@info.com", Password = "password234", Role = "Employee" },
                new Employee { EmployeeId = 3, Name = "Admin", Email = "admin@info.com", Password = "password567", Role = "Admin" }

            );

			//Seed driver data
			modelBuilder.Entity<Driver>().HasData(
		   new Driver
		   {
			   DriverID = 1,
			   DriverName = "Emma Nilsson",
			   CarReg = "ABC123",
			   NoteDate = DateTime.Now.AddMonths(-2),
			   NoteDescription = "Added to System",
			   ResponsibleEmployee = "Alice Johnson",
			   BeloppUt = 150,
			   BeloppIn = 0,
			   TotalBeloppUt = 150,
			   TotalBeloppIn = 0
		   },
		   new Driver
		   {
			   DriverID = 2,
			   DriverName = "Per Karlsson",
			   CarReg = "XYZ987",
			   NoteDate = DateTime.Now.AddMonths(-1),
			   NoteDescription = "Added to System",
			   ResponsibleEmployee = "Bob Smith",
			   BeloppUt = 100,
			   BeloppIn = 0,
			   TotalBeloppUt = 150,
			   TotalBeloppIn = 0
		   },

			  new Driver
			  {
				  DriverID = 3,
				  DriverName = "Olle Persson",
				  CarReg = "ATZ127",
				  NoteDate = DateTime.Now.AddMonths(-1),
				  NoteDescription = "Added to System",
				  ResponsibleEmployee = "Bob Smith",
				  BeloppUt = 0,
				  BeloppIn = 150,
				  TotalBeloppUt = 0,
				  TotalBeloppIn = 150
			  }
	   );

			// Seed Event data
			modelBuilder.Entity<Event>().HasData(
				new Event
				{
					EventID = 1,
					DriverID = 1,
					NoteDate = DateTime.Now.AddDays(-10),
					NoteDescription = "Speeding violation",
					BeloppUt = 100,
					BeloppIn = 0
				},
				new Event
				{
					EventID = 2,
					DriverID = 1,
					NoteDate = DateTime.Now.AddDays(-20),
					NoteDescription = "Routine maintenance",
					BeloppUt = 50,
					BeloppIn = 0
				},
				new Event
				{
					EventID = 3,
					DriverID = 2,
					NoteDate = DateTime.Now.AddDays(-5),
					NoteDescription = "Tire replacement",
					BeloppUt = 100,
					BeloppIn = 0
				},
				new Event
						{
					EventID = 4,
					DriverID = 3,
					NoteDate = DateTime.Now.AddDays(-3),
					NoteDescription = "Package deliverd",
					BeloppUt = 0,
					BeloppIn = 150
				}
			);
		}
	}




}
