using LocalLibrary.Entity;
using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace LocalLibrary
{
    public class DataSeederContributor
: IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Book, Guid> _bookRepo;

        public DataSeederContributor(IRepository<Book, Guid> bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepo.GetCountAsync() <= 0)
            {
                await _bookRepo.InsertAsync(
                  new Book
                  {
                     Author = "J. K. Rowling",
                     Section = Section.Fiction,
                     Title = "Harry Potter",                      
                  },
                  autoSave: true
              );

                await _bookRepo.InsertAsync(
                  new Book
                  {
                      Author = "Nicholas Spice",
                      Section = Section.Magazine,
                      Title = "London Review of Books",
                  },
                  autoSave: true
              );



                await _bookRepo.InsertAsync(
                  new Book
                  {
                      Author = "Yuval Noah Harari",
                      Section = Section.Non_Fiction,
                      Title = "Sapiens: A Brief History of Humankind",
                  },
                  autoSave: true
              );



            }
        }
    }
}