using System;
class GradeCalculate
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter Physics Marks : ");
		float physicsMarks = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Enter Chemistry Marks : ");
		float chemistryMarks = Convert.ToSingle(Console.ReadLine());

		Console.WriteLine("Enter Maths Marks : ");
		float mathsMarks = Convert.ToSingle(Console.ReadLine());

		float avgPercentage = ((physicsMarks + chemistryMarks + mathsMarks) / 300) * 100;
		Console.WriteLine(avgPercentage);

		if(avgPercentage >= 80){
			Console.WriteLine("Level 4 , above agency normalized standards");
		}else if(avgPercentage >= 70 && avgPercentage <= 79){
			Console.WriteLine("Level 3, at agency normalized standards");
		}else if(avgPercentage >= 60 && avgPercentage <= 69){
			Console.WriteLine("Level 2, below but approaching agency-normalized standards");
		}else if(avgPercentage >= 50 && avgPercentage <= 59){
			Console.WriteLine("Level 1, well below agency normalized standards");
		}else if(avgPercentage >= 40 && avgPercentage <= 49){
			Console.WriteLine("Level 1, too below agency normalized standards");
		}else{
			Console.WriteLine("Remedial standards");
		}

	}
}