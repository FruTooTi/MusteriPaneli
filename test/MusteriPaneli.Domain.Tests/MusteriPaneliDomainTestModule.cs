using MusteriPaneli.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MusteriPaneli;

[DependsOn(
    typeof(MusteriPaneliEntityFrameworkCoreTestModule)
    )]
public class MusteriPaneliDomainTestModule : AbpModule
{

}
