using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace LocalLibrary.Data
{
    /* This is used if database provider does't define
     * ILocalLibraryDbSchemaMigrator implementation.
     */
    public class NullLocalLibraryDbSchemaMigrator : ILocalLibraryDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}