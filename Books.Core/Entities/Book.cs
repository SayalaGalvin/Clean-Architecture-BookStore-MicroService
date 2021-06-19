using Books.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Core.Entities
{
    public class Book : Entity
    {
        public string BookName {get; set;}

        public string AuthorName { get; set; }

        public string Publisher { get; set; }

        public string NoOfPages { get; set; }

    }
}
