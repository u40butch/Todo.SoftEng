using Todo.SoftEng.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Todo.SoftEng.Permissions;

public class SoftEngPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SoftEngPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SoftEngPermissions.MyPermission1, L("Permission:MyPermission1"));

        var todoPermission = myGroup.AddPermission(SoftEngPermissions.Todo.Default, L("Permission:Todo"));
        todoPermission.AddChild(SoftEngPermissions.Todo.Create, L("Permission:Create"));
        todoPermission.AddChild(SoftEngPermissions.Todo.Update, L("Permission:Update"));
        todoPermission.AddChild(SoftEngPermissions.Todo.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SoftEngResource>(name);
    }
}
