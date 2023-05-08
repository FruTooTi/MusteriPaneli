using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace MusteriPaneli.Web;

[Dependency(ReplaceServices = true)]
public class MusteriPaneliBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MusteriPaneli";
}
