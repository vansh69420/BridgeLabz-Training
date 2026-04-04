using System;
class Abundant
{
	public static void Main(string[] args)
	{
		int num = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for(int i = 1; i < num; i++){
			if(num % i == 0){
				sum += i;
			}
		}
		if(sum > num){
			Console.WriteLine("It is a Abundant Number");
		}else{
			Console.WriteLine("It is not a Abundant Number");
		}
	}
}