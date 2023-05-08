using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MusteriPaneli.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MusteriPaneliDbContextFactory : IDesignTimeDbContextFactory<MusteriPaneliDbContext>
{
    public MusteriPaneliDbContext CreateDbContext(string[] args)
    {
        MusteriPaneliEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<MusteriPaneliDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new MusteriPaneliDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MusteriPaneli.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
