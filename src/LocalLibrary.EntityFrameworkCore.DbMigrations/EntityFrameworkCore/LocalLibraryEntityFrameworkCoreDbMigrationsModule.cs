using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace LocalLibrary.EntityFrameworkCore
{
    [DependsOn(
        typeof(LocalLibraryEntityFrameworkCoreModule)
        )]
    public class LocalLibraryEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<LocalLibraryMigrationsDbContext>();
        }
    }
}
