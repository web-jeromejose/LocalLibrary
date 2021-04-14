using LocalLibrary.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace LocalLibrary.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(LocalLibraryEntityFrameworkCoreDbMigrationsModule),
        typeof(LocalLibraryApplicationContractsModule)
        )]
    public class LocalLibraryDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
