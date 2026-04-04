using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name;
    public JsonFieldAttribute(string name) => Name = name;
}

class UserJson
{
    [JsonField("user_name")]
    public string Name = "Vansh";

    [JsonField("user_age")]
    public int Age = 21;
}

class JsonSerialization
{
    static void Main()
    {
        UserJson user = new UserJson();
        Console.Write("{ ");

        foreach (FieldInfo f in typeof(UserJson).GetFields())
        {
            JsonFieldAttribute attr = f.GetCustomAttribute<JsonFieldAttribute>();
            Console.Write($"\"{attr.Name}\": \"{f.GetValue(user)}\" ");
        }

        Console.Write("}");
    }
}
