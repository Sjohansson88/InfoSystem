using System.ComponentModel.DataAnnotations;

namespace InfoSystem.Models
{
	public class Employee
	{
		[Key]
		public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Password must be at least 5 characters long.")]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-zA-Z]).{5,}$", ErrorMessage = "Password must be at least 5 characters and contain at least one number.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Role is required.")]
        public string Role { get; set; }
	
	}
}
