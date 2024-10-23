namespace LibraryManagementWebApp.Models
{
	public class Loan
	{
		public int LoanId { get; set; }
		public int ReaderId { get; set; }
		public int LibraryBookId { get; set; }
		public DateTime LoanDate { get; set; }
		public DateTime DueDate { get; set; }
		public DateTime? ReturnDate { get; set; }

		public Reader Reader { get; set; }
		public LibraryBook LibraryBook { get; set; }
	}

}
