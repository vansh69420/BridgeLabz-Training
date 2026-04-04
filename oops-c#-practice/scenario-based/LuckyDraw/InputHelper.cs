using System;
class InputHelper
{
    public static bool TryGetNumber(out int number)
    {
        string input = Console.ReadLine();

        if(input.ToLower() == "exit")
        {
            number = -1;
            return false;
        }
        return int.TryParse(input, out number);
    }
}