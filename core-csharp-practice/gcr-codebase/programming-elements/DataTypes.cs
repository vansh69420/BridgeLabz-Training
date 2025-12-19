using System;
class DataTypes
{
    public static void Main(string[] args)
    {
        int num = 5;
        double doubleNum = 5.0;
        float floatNum = 3.5f;
        char ch = 'A';
        string str = "Hello World";
        bool boolVar = true;

        Console.WriteLine("Integer " + num);
        Console.WriteLine("Double " + doubleNum);
        Console.WriteLine("Float " + floatNum);
        Console.WriteLine("Character " + ch);
        Console.WriteLine("String " + str);
        Console.WriteLine("Boolean " + boolVar);


        //  TypeCasting Integer to Float
        int a = 5;
        float f = a;
        Console.WriteLine("Integer to Float " + f);

        //  TypeCasting Integer to Double
        int a1 = 6;
        double intToDouble = a1;
        Console.WriteLine("Integer to Double " + intToDouble);

        //  TypeCasting Integer to Char
        int a2 = 65;
        char intToChar = (char)a2;
        Console.WriteLine("Integer to Char " + intToChar);

        //  TypeCasting Integer to String
        string str2 = num.ToString();
        Console.WriteLine("Integer to String " + str2);

        //  TypeCasting Double to Integer
        int num2 = (int)doubleNum;
        Console.WriteLine("Double to Integer " + num2);

        // TypeCasting Double to Float
        float f2 = (float)doubleNum;
        Console.WriteLine("Double to Float " + f2);

        // TypeCasting Double to Char
        double d2 = 65.0;
        char ch2 = (char)d2;
        Console.WriteLine("Double to Char " + ch2);

        // TypeCasting Double to String
        string str3 = doubleNum.ToString();
        Console.WriteLine("Double to String " + str3);

        // TypeCasting Float to Int
        float f3 = (int)num;
        Console.WriteLine("Float to Integer " + f3);

        // TypeCasting Float to Double
        double d3 = floatNum;
        Console.WriteLine("Float to Double " + d3);

        // TypeCasting Float to Char
        float f4 = 66.0f;
        char ch3 = (char)f4;
        Console.WriteLine("Float to Char " + ch3);

        // TypeCasting Float to String
        string str4 = floatNum.ToString();
        Console.WriteLine("Float to String" + str4);

        // TypeCasting Char to Int
        int num3 = ch;
        Console.WriteLine("Char to Int " + num3);

        // TypeCasting Char to Double 
        double d4 = ch;
        Console.WriteLine("Char to Double " + d4);

        // TypeCasting Char to Float
        float f5 = ch;
        Console.WriteLine("Char to Float " + f5);

        // TypeCasting Char to String
        string str5 = ch.ToString();
        Console.WriteLine("Char to String " + str5);




        








    }
}