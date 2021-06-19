using Books.Application.Commands;
using Books.Application.Queries;
using Books.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books.API.Controllers
{
    public class BookController : ApiController
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookResponse>>> GetBookByAuthorName(string authorName)
        {
	        var query = new GetBookByAuthorNameQuery(authorName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<BookResponse>>> CheckoutOrder([FromBody] CreateBookCommand command)
        {
	        var result = await _mediator.Send(command);
	        return Ok(result);
        }
    }
}
