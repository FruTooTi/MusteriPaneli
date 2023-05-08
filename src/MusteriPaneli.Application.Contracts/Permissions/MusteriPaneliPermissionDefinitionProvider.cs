using MusteriPaneli.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MusteriPaneli.Permissions;

public class MusteriPaneliPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MusteriPaneliPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MusteriPaneliPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MusteriPaneliResource>(name);
    }
}
