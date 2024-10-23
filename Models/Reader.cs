namespace LibraryManagementWebApp.Models
{
	public class Reader
	{
		public int ReaderId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }

		public ICollection<Loan> Loans { get; set; }
	}

}
