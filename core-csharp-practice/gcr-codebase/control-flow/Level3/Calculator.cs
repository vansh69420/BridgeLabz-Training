using System;
class Calculator
{
	public static void Main(string[] args)
	{
		double first = Convert.ToDouble(Console.ReadLine());
		double second = Convert.ToDouble(Console.ReadLine());

		string op = Console.ReadLine();

		if(op == "+" || op == "-" || op == "*" || op == "/"){
			switch (op)
			{
				case "+":
					double sum = first + second;
					Console.WriteLine($"{first} + {second} = {sum}");
					break;

				case "-":
					double sub = first - second;
					Console.WriteLine($"{first} - {second} = {sub}");
					break;

				case "*":
					double mult = first * second;
					Console.WriteLine($"{first} * {second} = {mult}");
					break;

				case "/":
					double div = first / second;
					Console.WriteLine($"{first} / {second} = {div}");
					break;
			}
		}else{
			Console.WriteLine("Invalid Operator.");
		}
	}
}