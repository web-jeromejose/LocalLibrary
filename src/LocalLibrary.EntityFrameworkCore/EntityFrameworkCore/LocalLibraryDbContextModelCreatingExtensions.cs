using LocalLibrary.Entity;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace LocalLibrary.EntityFrameworkCore
{
    public static class LocalLibraryDbContextModelCreatingExtensions
    {
        public static void ConfigureLocalLibrary(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            builder.Entity<Book>(b =>
            {
                b.ToTable(LocalLibraryConsts.DbTablePrefix + "Books", LocalLibraryConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //...
            });
        }
    }
}