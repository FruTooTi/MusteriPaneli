using System.Threading.Tasks;

namespace MusteriPaneli.Data;

public interface IMusteriPaneliDbSchemaMigrator
{
    Task MigrateAsync();
}
