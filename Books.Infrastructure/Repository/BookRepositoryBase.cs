using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Books.Infrastructure.Repository
{
    public class BookRepositoryBase
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public Task<IEnumerable<Book>> GetBookByAuthorName(string authorName)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}