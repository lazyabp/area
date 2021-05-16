using Lazy.Abp.AreaKit.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Lazy.Abp.AreaKit.Permissions
{
    public class AreaKitPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AreaKitPermissions.GroupName, L("Permission:AreaKit"));

            var addressPermission = myGroup.AddPermission(AreaKitPermissions.Address.Default, L("Permission:Address"));
            addressPermission.AddChild(AreaKitPermissions.Address.Create, L("Permission:Create"));
            addressPermission.AddChild(AreaKitPermissions.Address.Update, L("Permission:Update"));
            addressPermission.AddChild(AreaKitPermissions.Address.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AreaKitResource>(name);
        }
    }
}
