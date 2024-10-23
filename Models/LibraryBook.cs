namespace LibraryManagementWebApp.Models
{
	public class LibraryBook
	{
		public int LibraryBookId { get; set; }
		public int LibraryId { get; set; }
		public int BookId { get; set; }
		public int QuantityAvailable { get; set; }

		public Library Library { get; set; }
		public Book Book { get; set; }
		public ICollection<Loan> Loans { get; set; }
	}

}
