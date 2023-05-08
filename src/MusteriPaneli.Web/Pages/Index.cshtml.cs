using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace MusteriPaneli.Web.Pages;

public class IndexModel : MusteriPaneliPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
