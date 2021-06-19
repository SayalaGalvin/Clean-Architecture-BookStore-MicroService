using Books.Application.Mapper;
using Books.Application.Queries;
using Books.Application.Responses;
using Books.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Books.Application.Handler
{
    public class GetBookByAuthorNameHandler : IRequestHandler<GetBookByAuthorNameQuery, IEnumerable<BookResponse>>
    {
        private readonly IBookRepository _bookRepository;

        public GetBookByAuthorNameHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<IEnumerable<BookResponse>> Handle(GetBookByAuthorNameQuery request, CancellationToken cancellationToken)
        {
            var bookList = await _bookRepository.GetBookByAuthorName(request.AuthorName);
            var bookResponseList = BookMapper.Mapper.Map<IEnumerable<BookResponse>>(bookList);
            return bookResponseList;
        }
    }
}
