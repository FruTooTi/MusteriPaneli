using Volo.Abp.Settings;

namespace MusteriPaneli.Settings;

public class MusteriPaneliSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MusteriPaneliSettings.MySetting1));
    }
}
