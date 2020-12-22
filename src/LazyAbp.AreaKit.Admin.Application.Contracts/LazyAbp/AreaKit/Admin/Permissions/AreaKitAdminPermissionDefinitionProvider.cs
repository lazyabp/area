using LazyAbp.AreaKit.Localization;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace LazyAbp.AreaKit.Admin.Permissions
{
    public class AreaKitAdminPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AreaKitAdminPermissions.GroupName, L("Permission:AreaKitAdmin"));

            var countryPermission = myGroup.AddPermission(AreaKitAdminPermissions.Country.Default, L("Permission:Country"));
            countryPermission.AddChild(AreaKitAdminPermissions.Country.Create, L("Permission:Create"));
            countryPermission.AddChild(AreaKitAdminPermissions.Country.Update, L("Permission:Update"));
            countryPermission.AddChild(AreaKitAdminPermissions.Country.Delete, L("Permission:Delete"));

            var stateProvincePermission = myGroup.AddPermission(AreaKitAdminPermissions.StateProvince.Default, L("Permission:StateProvince"));
            stateProvincePermission.AddChild(AreaKitAdminPermissions.StateProvince.Create, L("Permission:Create"));
            stateProvincePermission.AddChild(AreaKitAdminPermissions.StateProvince.Update, L("Permission:Update"));
            stateProvincePermission.AddChild(AreaKitAdminPermissions.StateProvince.Delete, L("Permission:Delete"));

            var cityPermission = myGroup.AddPermission(AreaKitAdminPermissions.City.Default, L("Permission:City"));
            cityPermission.AddChild(AreaKitAdminPermissions.City.Create, L("Permission:Create"));
            cityPermission.AddChild(AreaKitAdminPermissions.City.Update, L("Permission:Update"));
            cityPermission.AddChild(AreaKitAdminPermissions.City.Delete, L("Permission:Delete"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AreaKitResource>(name);
        }
    }
}
