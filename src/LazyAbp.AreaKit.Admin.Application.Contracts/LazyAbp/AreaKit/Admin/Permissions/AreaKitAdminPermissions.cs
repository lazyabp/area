using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Reflection;

namespace LazyAbp.AreaKit.Admin.Permissions
{
    public class AreaKitAdminPermissions
    {
        public const string GroupName = "AreaKit.Admin";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AreaKitAdminPermissions));
        }

        public class Country
        {
            public const string Default = GroupName + ".Country";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class StateProvince
        {
            public const string Default = GroupName + ".StateProvince";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }

        public class City
        {
            public const string Default = GroupName + ".City";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
