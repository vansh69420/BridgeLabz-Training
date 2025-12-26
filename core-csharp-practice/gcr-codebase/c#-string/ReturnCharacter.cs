using System;
class ReturnCharacter
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string: ");
        string str = Console.ReadLine();

        char[] returnUsingMethod = ReturnCharactersUsingMethod(str);
        char[] returnUsingCharArray = str.ToCharArray();

        Console.WriteLine("Characters using method:");
        foreach (char c in returnUsingMethod)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine("\nCharacters using ToCharArray:");
        foreach (char c in returnUsingCharArray)
        {
            Console.Write(c + " ");
        }
    }

    public static char[] ReturnCharactersUsingMethod(string str)
    {
        char[] character = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            character[i] = str[i];
        }
        return character;
    }
}