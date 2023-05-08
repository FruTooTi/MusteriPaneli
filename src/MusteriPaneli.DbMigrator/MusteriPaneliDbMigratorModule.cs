using MusteriPaneli.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MusteriPaneli.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MusteriPaneliEntityFrameworkCoreModule),
    typeof(MusteriPaneliApplicationContractsModule)
    )]
public class MusteriPaneliDbMigratorModule : AbpModule
{

}
