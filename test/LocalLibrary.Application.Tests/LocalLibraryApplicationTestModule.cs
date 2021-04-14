using Volo.Abp.Modularity;

namespace LocalLibrary
{
    [DependsOn(
        typeof(LocalLibraryApplicationModule),
        typeof(LocalLibraryDomainTestModule)
        )]
    public class LocalLibraryApplicationTestModule : AbpModule
    {

    }
}