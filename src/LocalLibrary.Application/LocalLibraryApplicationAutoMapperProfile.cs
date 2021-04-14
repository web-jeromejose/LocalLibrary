using AutoMapper;
using LocalLibrary.Entity;

namespace LocalLibrary
{
    public class LocalLibraryApplicationAutoMapperProfile : Profile
    {
        public LocalLibraryApplicationAutoMapperProfile()
        {
            /* JEROME April 14 2021
             *   */
            CreateMap<Book, BookDto>();
            CreateMap<CreateUpdateBookDto, Book>(); //this will create update the book entity
        }
    }
}