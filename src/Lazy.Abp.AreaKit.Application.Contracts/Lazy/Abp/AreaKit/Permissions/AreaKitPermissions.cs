using Volo.Abp.Reflection;

namespace Lazy.Abp.AreaKit.Permissions
{
    public class AreaKitPermissions
    {
        public const string GroupName = "AreaKit";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AreaKitPermissions));
        }

        public class Address
        {
            public const string Default = GroupName + ".Address";
            public const string Update = Default + ".Update";
            public const string Create = Default + ".Create";
            public const string Delete = Default + ".Delete";
        }
    }
}
