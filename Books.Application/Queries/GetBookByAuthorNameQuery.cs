using Books.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Application.Queries
{
    public class GetBookByAuthorNameQuery : IRequest<IEnumerable<BookResponse>>
    {
        public string AuthorName { get; set; }

        public GetBookByAuthorNameQuery(string authorName)
        {
            AuthorName = authorName;
        }
    }
}
