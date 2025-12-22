using System;
class CheckNumber
{
	public static void Main(string[] args)
	{
		int num = Convert.ToInt32(Console.ReadLine());

		if(num > 0){
			Console.WriteLine($"{num} is a Positive Number");
		} else if (num < 0){
			Console.WriteLine($"{num} is a Negative Number ");
		}else{
			Console.WriteLine("It is Zero");
		}

	}
}