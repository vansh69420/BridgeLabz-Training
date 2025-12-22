using System;
class FindLeapYear
{
	public static void Main(string[] args)
	{
		int year = Convert.ToInt32(Console.ReadLine());

		if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0){
			Console.WriteLine("It is a Leap Year");
		}else{
			Console.WriteLine("It is not a Leap Year");
		}
	}
}