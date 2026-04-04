using System;

class StringUtility
{
    // Static entry method (utility behavior)
    public static string CleanseAndInvert(string input)
    {
        if (input == null || input.Length < 6)
        {
            throw new InvalidInputException("Input is null or length is less than 6");
        }

        StringUtility util = new StringUtility();

        if (!util.IsValidWord(input))
        {
            throw new InvalidInputException("Input contains invalid characters");
        }

        input = input.ToLower();

        string filtered = util.RemoveEvenAsciiCharacters(input);
        string reversed = util.ReverseString(filtered);
        string finalResult = util.ApplyCaseTransformation(reversed);

        return finalResult;
    }

    // Non-static helper methods

    private bool IsValidWord(string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];

            if (!(ch >= 'A' && ch <= 'Z') &&
                !(ch >= 'a' && ch <= 'z'))
            {
                return false;
            }
        }
        return true;
    }

    private string RemoveEvenAsciiCharacters(string input)
    {
        string result = "";

        for (int i = 0; i < input.Length; i++)
        {
            int ascii = (int)input[i];

            if (ascii % 2 != 0)
            {
                result += input[i];
            }
        }
        return result;
    }

    private string ReverseString(string input)
    {
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;
    }

    private string ApplyCaseTransformation(string input)
    {
        char[] arr = input.ToCharArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                {
                    arr[i] = (char)(arr[i] - 32);
                }
            }
        }
        return new string(arr);
    }
}
