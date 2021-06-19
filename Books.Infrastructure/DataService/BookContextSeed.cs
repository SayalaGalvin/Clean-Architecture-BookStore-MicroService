using Books.Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Infrastructure.DataService
{
    public class BookContextSeed
    {
		public static async Task SeedAsync(BookContext bookContext, ILoggerFactory loggerFactory, int? retry = 0)
		{
			int retryForAvailability = retry.Value;
			try
			{
				await bookContext.Database.EnsureCreatedAsync();

				if (!bookContext.Books.Any())
				{
					bookContext.Books.AddRange(GetBooks());
					await bookContext.SaveChangesAsync();
				}
			}
			catch (Exception ex)
			{
				if (retryForAvailability < 3)
				{
					retryForAvailability++;
					var log = loggerFactory.CreateLogger<BookContextSeed>();
					log.LogError($"Connetion Issue: {ex.Message}");
					await SeedAsync(bookContext, loggerFactory, retryForAvailability);
				}
			}
		}

		private static IEnumerable<Book> GetBooks()
		{
			return new List<Book>(){
				new Book { BookName = "Hapana", AuthorName="T.B.Ilangarathna", Publisher= "Gunasena", NoOfPages= "300" }
			 };
		}
	}
}
