using System.Threading.Tasks;

namespace LocalLibrary.Data
{
    public interface ILocalLibraryDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
