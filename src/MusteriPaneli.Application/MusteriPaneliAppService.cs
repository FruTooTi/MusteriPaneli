using System;
using System.Collections.Generic;
using System.Text;
using MusteriPaneli.Localization;
using Volo.Abp.Application.Services;

namespace MusteriPaneli;

/* Inherit your application services from this class.
 */
public abstract class MusteriPaneliAppService : ApplicationService
{
    protected MusteriPaneliAppService()
    {
        LocalizationResource = typeof(MusteriPaneliResource);
    }
}
