using System;
class Armstrong
{
	public static void Main(string[] args)
	{
		int num = Convert.ToInt32(Console.ReadLine());

		int originalNum = num;

		int sum = 0;

		while(originalNum > 0){
			int remainder = originalNum % 10;
			sum += remainder * remainder * remainder;

			originalNum = originalNum / 10;
		}
		if(num == sum){
			Console.WriteLine("It is a Armstrong Number");
		}else{
			Console.WriteLine("It is not an Armstrong Number");
		}
	}
}