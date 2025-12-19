using System;
class AccessModifier
{
	public static void Main(string[] args)
	{
		PublicClass pub = new PublicClass();
        pub.PublicMethod();
        Console.WriteLine(pub.publicVar);
	}
	public class PublicClass
	{
		public int publicVar = 10;

		public void PublicMethod()
		{
			Console.WriteLine("Public Method");
		}
	}
}