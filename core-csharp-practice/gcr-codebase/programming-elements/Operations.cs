using System;
class Animal {}
class Dog : Animal {}
class Operations
{
	public static void Main(string[] args)
	{
		// Arithimatic Operators
		int num1 = 56;
		int num2 = 45;

		Console.WriteLine("Addition: " + (num1 + num2)); 
		Console.WriteLine("Subtraction: " + (num1 - num2)); 
		Console.WriteLine("Multiplication: " + (num1 * num2)); 
		Console.WriteLine("Division: " + (num1 / num2)); 
		Console.WriteLine("Modulus: " + (num1 % num2)); 

		Console.WriteLine("");

		// Relational Operators
		int n1 = 10;
		int n2= 5;

		Console.WriteLine("n1 == n2: " + (n1 == n2)); 
		Console.WriteLine("n1 != n2: " + (n1 != n2)); 
		Console.WriteLine("n1 > n2: " + (n1 > n2)); 
		Console.WriteLine("n1 < n2: " + (n1 < n2)); 
		Console.WriteLine("n1 >= n2: " + (n1 >= n2)); 
		Console.WriteLine("n1 <= n2: " + (n1 <= n2)); 

		Console.WriteLine("");

		// Logical Operators

		bool x = true;
		bool y = false;

		Console.WriteLine("x && y: " + (x && y)); 
		Console.WriteLine("x || y: " + (x || y)); 
		Console.WriteLine("!x: " + (!x)); 
		Console.WriteLine("!y: " + (!y));

		Console.WriteLine("");

		// Assignment Operator

		int a = 56;
		int b = 34;

		a += b; 
		Console.WriteLine("a += b: " + a); 

		a -= b; 
		Console.WriteLine("a -= b: " + a); 

		a *= b; 
		Console.WriteLine("a *= b: " + a); 

		a /= b; 
		Console.WriteLine("a /= b: " + a); 

		a %= b; 
		Console.WriteLine("a %= b: " + a); 


		Console.WriteLine("");
		// Unary Operators

		int c = 5;

		Console.WriteLine("c: " + a); 
		Console.WriteLine("++c: " + ++a); 
		Console.WriteLine("c++: " + a++); 
		Console.WriteLine("c: " + a); 
		Console.WriteLine("--c: " + --a); 
		Console.WriteLine("c--: " + a--); 
		Console.WriteLine("c: " + a); 

		Console.WriteLine("");

		// Ternary Operators
		int n3 = 10;
		int n4 = 20;
		int max = (n3 > n4) ? n3 : n4;
		Console.WriteLine("Max: " + max);

		Console.WriteLine("");

		// Is Operator
		Animal animal = new Dog();

		Console.WriteLine("animal is Animal: " + (animal is Animal)); 
		Console.WriteLine("animal is Dog: " + (animal is Dog)); 
		Console.WriteLine("animal is String: " + (animal is string)); 
	}
}