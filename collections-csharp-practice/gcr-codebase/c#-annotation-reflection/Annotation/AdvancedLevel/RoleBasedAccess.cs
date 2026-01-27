using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role;
    public RoleAllowedAttribute(string role) => Role = role;
}

class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteUser()
    {
        Console.WriteLine("User deleted");
    }
}

class RoleBasedAccess
{
    static void Main()
    {
        string currentRole = "USER";
        MethodInfo method = typeof(AdminService).GetMethod("DeleteUser");

        RoleAllowedAttribute attr = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attr.Role == currentRole)
            method.Invoke(new AdminService(), null);
        else
            Console.WriteLine("Access Denied!");
    }
}
