using LocalLibrary.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace LocalLibrary
{
    [DependsOn(
        typeof(LocalLibraryEntityFrameworkCoreTestModule)
        )]
    public class LocalLibraryDomainTestModule : AbpModule
    {

    }
}