using System;
class Uppercase
{
    public static void Main(string[] args)
    {
        string str = "hello world";
        string upperstr = UppercaseString(str);
        string upperstrUsingToUpper = str.ToUpper();
        Console.WriteLine("Uppercase using custom method: " + upperstr);
        Console.WriteLine("Uppercase using ToUpper(): " + upperstrUsingToUpper);
    }

    public static string UppercaseString(string s)
    {
        char[] chars = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'a' && s[i] <= 'z')
            {
                chars[i] = (char)(s[i] - ('a' - 'A'));
            }else
            {
                chars[i] = s[i];
            }
        }
        return new string(chars);
    }
}