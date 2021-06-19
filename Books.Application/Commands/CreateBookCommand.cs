using Books.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Application.Commands
{
    public class CreateBookCommand : IRequest<BookResponse>
    {
        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public string Publisher { get; set; }

        public string NoOfPages { get; set; }
    }
}
