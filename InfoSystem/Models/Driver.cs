using System.ComponentModel.DataAnnotations;

namespace InfoSystem.Models
{
	public class Driver
	{
		[Key]
		public int DriverID { get; set; }
        [Required(ErrorMessage = "Driver Name is required.")]
        public string DriverName { get; set; }
        [Required(ErrorMessage = "Car Registration is required.")]
        public string CarReg { get; set; }
        [DataType(DataType.Date)]
        public DateTime NoteDate { get; set; }
		public string NoteDescription { get; set; }
        [Required(ErrorMessage = "Responsible Employee is required.")]
        public string ResponsibleEmployee { get; set; }
		public decimal BeloppUt { get; set; }
		public decimal BeloppIn { get; set; }
		public decimal TotalBeloppUt { get; set; }
		public decimal TotalBeloppIn { get; set; }
        public string ActionType { get; set; }
        public ICollection<Event> Events { get; set; }
	}
}
