using MusteriPaneli.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MusteriPaneli.Web.Pages;

public abstract class MusteriPaneliPageModel : AbpPageModel
{
    protected MusteriPaneliPageModel()
    {
        LocalizationResourceType = typeof(MusteriPaneliResource);
    }
}
