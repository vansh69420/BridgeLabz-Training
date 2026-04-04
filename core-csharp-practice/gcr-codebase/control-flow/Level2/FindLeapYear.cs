using System;
class FindLeapYear
{
	public static void Main(string[] args)
	{
		int year = Convert.ToInt32(Console.ReadLine());

		if(year < 1582){
			Console.WriteLine("Year should be later than or has to be 1582");
		}else{

			if(year % 400 == 0){
				Console.WriteLine("It is a Leap Year");
			}else if(year % 100 == 0){
				Console.WriteLine("It is not a Leap Year");
			}else if(year % 4 == 0){
				Console.WriteLine("It is a Leap Year");
			}else{
				Console.WriteLine("It is not a Leap Year");
			}
		}


	}
}