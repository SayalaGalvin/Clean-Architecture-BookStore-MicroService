using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Application.Responses
{
    public class BookResponse
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        public string AuthorName { get; set; }

        public string Publisher { get; set; }

        public string NoOfPages { get; set; }
    }
}
