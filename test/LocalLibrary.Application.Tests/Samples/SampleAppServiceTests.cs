using LocalLibrary.Entity;
using LocalLibrary.Service;
using Shouldly;
using System;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Xunit;

namespace LocalLibrary.Samples
{
    /* This is just an example test class.
     * Normally, you don't test code of the modules you are using
     * (like IIdentityUserAppService here).
     * Only test your own application services.
     */
    public class SampleAppServiceTests : LocalLibraryApplicationTestBase
    {
        private readonly IIdentityUserAppService _userAppService;
        private readonly IBookAppService _bookAppService;

        public SampleAppServiceTests(IBookAppService bookRepo)
        {
            _userAppService = GetRequiredService<IIdentityUserAppService>();
            _bookAppService = GetRequiredService<IBookAppService>();
        }
        //jerome test the Books List GET and CREATE
        [Fact]
        public async Task Initial_Data_Shoud_Have_BookList()
        {
            //Act
            var result = await _bookAppService.GetListAsync( new Volo.Abp.Application.Dtos.PagedAndSortedResultRequestDto() );

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(b => b.Author == "");
        }


        [Fact]
        public async Task Should_Create_A_Valid_Book()
        {
            //Act
            var result = await _bookAppService.CreateAsync(
                new CreateUpdateBookDto
                {
                    Author = "Jerome",
                    Section=Section.Fiction,
                    Title = "Adventure to UK" 
                }
            );

            //Assert
            result.Id.ShouldNotBe(Guid.Empty);
            result.Author.ShouldBe("Jerome");
        }



        [Fact]
        public async Task Initial_Data_Should_Contain_Admin_User()
        {
            //Act
            var result = await _userAppService.GetListAsync(new GetIdentityUsersInput());

            //Assert
            result.TotalCount.ShouldBeGreaterThan(0);
            result.Items.ShouldContain(u => u.UserName == "admin");
        }
    }
}
