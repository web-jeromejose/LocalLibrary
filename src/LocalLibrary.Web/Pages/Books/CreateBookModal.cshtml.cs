using LocalLibrary.Entity;
using LocalLibrary.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LocalLibrary.Web.Pages.Books
{
    public class CreateBookModalModel : LocalLibraryPageModel
    {
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        private readonly IBookAppService _bookAppService;

        public CreateBookModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}