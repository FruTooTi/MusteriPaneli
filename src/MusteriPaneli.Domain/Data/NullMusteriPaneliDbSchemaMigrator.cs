using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.Data;

/* This is used if database provider does't define
 * IMusteriPaneliDbSchemaMigrator implementation.
 */
public class NullMusteriPaneliDbSchemaMigrator : IMusteriPaneliDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
