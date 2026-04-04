using System;
class CheckPrime
{
	public static void Main(string[] args)
	{
		int num = Convert.ToInt32(Console.ReadLine());

		bool isPrime = true;

		for(int i = 2; i < num; i++){
			if(num % i == 0){
				isPrime = false;
				break;
			}
		}
		if(isPrime){
			Console.WriteLine("It is Prime");
		}else{
			Console.WriteLine("It is not Prime");
		}
	}
}