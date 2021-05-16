namespace Lazy.Abp.AreaKit
{
    public static class AreaKitDbProperties
    {
        public static string DbTablePrefix { get; set; } = "AreaKit";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "AreaKit";
    }
}
