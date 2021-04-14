using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace LocalLibrary.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class LocalLibraryMigrationsDbContextFactory : IDesignTimeDbContextFactory<LocalLibraryMigrationsDbContext>
    {
        public LocalLibraryMigrationsDbContext CreateDbContext(string[] args)
        {
            LocalLibraryEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<LocalLibraryMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new LocalLibraryMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../LocalLibrary.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
