using Books.Core.Entities;
using Books.Core.Repository;
using Books.Infrastructure.DataService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Infrastructure.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookContext bookContext) : base(bookContext)
        {

        }

        public async Task<IEnumerable<Book>> GetBookByAuthorName(string authorName)
        {
            return await _bookContext.Books
             .Where(b => b.AuthorName == authorName)
             .ToListAsync();
        }
    }
}
