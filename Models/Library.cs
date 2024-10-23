namespace LibraryManagementWebApp.Models
{
	public class Library
	{
		public int LibraryId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string PhoneNumber { get; set; }

		public ICollection<LibraryBook> LibraryBooks { get; set; }
	}

}
