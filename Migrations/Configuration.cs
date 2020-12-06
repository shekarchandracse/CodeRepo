namespace LibraryApp.Migrations
{
	using LibraryApp.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<BooksDb>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = true;
		}

		protected override void Seed(BooksDb context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data.
			context.Books.AddOrUpdate(
			  m => m.Title,
			  new Book
			  {
				  Title = "A Time to kill",
				  Author = "John Grisham",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "Lord of the Rings",
				  Author = "Tolkien",
				  Type = "Rent"
			  },
			  new Book
			  {
				  Title = "Harry Potter",
				  Author = "J K Rollings",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "And then there were none",
				  Author = "Agatha",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "Alice Adventures",
				  Author = "Lewis",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "Don Quixoite",
				  Author = "Miguel",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "The Lion",
				  Author = "Carrol",
				  Type = "Available"
			  },
			  new Book
			  {
				  Title = "Pinnochio",
				  Author = "Carlo",
				  Type = "Rent"
			  }, 
			  new Book
			  {
				  Title = "Catcher in the Ray",
				  Author = "Salinger",
				  Type = "Rent"
			  }
			  ,
			  new Book
			  {
				  Title = "The Kite Runner",
				  Author = "Kaled",
				  Type = "Rent"
			  }
			  );
		}
	}
}
