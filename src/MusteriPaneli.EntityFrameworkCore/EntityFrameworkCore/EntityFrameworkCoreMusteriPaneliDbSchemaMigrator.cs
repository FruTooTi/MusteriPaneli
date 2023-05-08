using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusteriPaneli.Data;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.EntityFrameworkCore;

public class EntityFrameworkCoreMusteriPaneliDbSchemaMigrator
    : IMusteriPaneliDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMusteriPaneliDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MusteriPaneliDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MusteriPaneliDbContext>()
            .Database
            .MigrateAsync();
    }
}
