using System.ComponentModel.DataAnnotations;

namespace InfoSystem.Models
{
	public class Event
	{
		[Key]
		public int EventID { get; set; }
		public DateTime NoteDate { get; set; }
        [Required(ErrorMessage = "Note description is required.")]
        public string NoteDescription { get; set; }
        public string ActionType { get; set; }
        public decimal BeloppUt { get; set; }
		public decimal BeloppIn { get; set; }

		public int DriverID { get; set; } 
		public Driver Driver { get; set; } 
	}
}
