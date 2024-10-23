using LibraryManagementWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementWebApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options)
			: base(options)
		{
		}

		public DbSet<Library> Libraries { get; set; }
		public DbSet<Book> Books { get; set; }
		public DbSet<LibraryBook> LibraryBooks { get; set; }
		public DbSet<Reader> Readers { get; set; }
		public DbSet<Loan> Loans { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<LibraryBook>()
				.HasOne(lb => lb.Library)
				.WithMany(l => l.LibraryBooks)
				.HasForeignKey(lb => lb.LibraryId);

			modelBuilder.Entity<LibraryBook>()
				.HasOne(lb => lb.Book)
				.WithMany(b => b.LibraryBooks)
				.HasForeignKey(lb => lb.BookId);

			modelBuilder.Entity<Loan>()
				.HasOne(l => l.Reader)
				.WithMany(r => r.Loans)
				.HasForeignKey(l => l.ReaderId);

			modelBuilder.Entity<Loan>()
				.HasOne(l => l.LibraryBook)
				.WithMany(lb => lb.Loans)
				.HasForeignKey(l => l.LibraryBookId);
		}
	}
}
