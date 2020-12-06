using System.Data.Entity;

namespace LibraryApp.Models
{
	public class BooksDb : DbContext
	{
		public DbSet<Book> Books { get; set; }

	}
}