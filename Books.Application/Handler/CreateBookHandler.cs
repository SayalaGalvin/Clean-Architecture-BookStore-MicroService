using Books.Application.Commands;
using Books.Application.Mapper;
using Books.Application.Responses;
using Books.Core.Entities;
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
    public class CreateBookHandler : IRequestHandler<CreateBookCommand, BookResponse>
    {

        private readonly IBookRepository _bookRepository;

        public CreateBookHandler(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<BookResponse> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {
            var bookEntity = BookMapper.Mapper.Map<Book>(request);
            if (bookEntity is null)
            {
                throw new ApplicationException("Issue with mapping");
            }
            var newBook = await _bookRepository.AddAsync(bookEntity);
            var bookRepsonse = BookMapper.Mapper.Map<BookResponse>(newBook);
            return bookRepsonse;
        }
    }
}
