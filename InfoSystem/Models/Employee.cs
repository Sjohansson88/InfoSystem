using System.ComponentModel.DataAnnotations;

namespace InfoSystem.Models
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Role { get; set; }
	
	}
}
