namespace LibraryManagementWebApp.Models
{
	public class Book
	{
		public int BookId { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }
		public string ISBN { get; set; }
		public string Publisher { get; set; }
		public int PublicationYear { get; set; }
		public string Genre { get; set; }

		public ICollection<LibraryBook> LibraryBooks { get; set; }
	}

}
