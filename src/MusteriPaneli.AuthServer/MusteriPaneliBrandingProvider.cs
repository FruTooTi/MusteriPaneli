using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli;

[Dependency(ReplaceServices = true)]
public class MusteriPaneliBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MusteriPaneli";
}
