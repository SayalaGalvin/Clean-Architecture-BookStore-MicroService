using AutoMapper;
using Books.Application.Commands;
using Books.Application.Responses;
using Books.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Application.Mappers
{
    class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {
            CreateMap<Book, BookResponse>().ReverseMap();
            CreateMap<Book, CreateBookCommand>().ReverseMap();
        }
    }
}
