namespace Todo.SoftEng.Permissions;

public static class SoftEngPermissions
{
    public const string GroupName = "SoftEng";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class Todo
    {
        public const string Default = GroupName + ".Todo";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
