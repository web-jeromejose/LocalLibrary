using AutoMapper;
using LocalLibrary.Entity;

namespace LocalLibrary.Web
{
    public class LocalLibraryWebAutoMapperProfile : Profile
    {
        public LocalLibraryWebAutoMapperProfile()
        {
           //jerome for CRUD in the book entity
                CreateMap<BookDto, CreateUpdateBookDto>();
            
        }
    }
}
