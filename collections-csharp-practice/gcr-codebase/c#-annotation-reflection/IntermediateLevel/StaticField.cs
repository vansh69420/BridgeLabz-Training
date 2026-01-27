using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticField
{
    static void Main()
    {
        Type t = typeof(Configuration);
        FieldInfo field = t.GetField("API_KEY", BindingFlags.Static | BindingFlags.NonPublic);

        field.SetValue(null, "NEW_KEY");
        Console.WriteLine("API Key Updated");
    }
}
