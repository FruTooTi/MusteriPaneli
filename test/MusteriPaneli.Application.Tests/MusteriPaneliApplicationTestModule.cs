using Volo.Abp.Modularity;

namespace MusteriPaneli;

[DependsOn(
    typeof(MusteriPaneliApplicationModule),
    typeof(MusteriPaneliDomainTestModule)
    )]
public class MusteriPaneliApplicationTestModule : AbpModule
{

}
