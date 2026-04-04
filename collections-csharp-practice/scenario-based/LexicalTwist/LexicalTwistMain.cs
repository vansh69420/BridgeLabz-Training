using System;

class LexicalTwistMain
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter the first word");
            string first = Console.ReadLine();
            LexicalTwistUtility.ValidateWord(first);

            Console.WriteLine("Enter the second word");
            string second = Console.ReadLine();
            LexicalTwistUtility.ValidateWord(second);

            LexicalTwistUtility utility = new LexicalTwistUtility();
            utility.ProcessWords(first, second);
        }
        catch (InvalidWordException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}
