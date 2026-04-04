using System;
class Salary
{
    public static void Main(string[] args)
    {
        double[] salaries = new double[10];
        double[] yearsOfService = new double[10];
        double[] newSalaries = new double[10];
        double[] bonuses = new double[10];
        double totalbonus = 0.0;
        double totalNewSalary = 0.0;
        double totalOldSalary = 0.0;
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter Salary of Employee" + (i + 1) + ": ");
            salaries[i] = Convert.ToDouble(Console.ReadLine());
            if (salaries[i] < 0)
            {
                Console.WriteLine("Salary cannot be negative. Please enter again.");
                i--;
                continue;
            }
            Console.WriteLine("Enter Years of Service of Employee" + (i + 1) + ": ");
            yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
            if (yearsOfService[i] < 0)
            {   
                Console.WriteLine("Years of Service cannot be negative. Please enter again.");
                i--;
                continue;
            }
        }
        for(int i = 0; i < 10; i++)
        {
            if(yearsOfService[i] > 5)
            {
                bonuses[i] = salaries[i] * 0.05;
            }
            else if(yearsOfService[i] <= 5)
            {
                bonuses[i] = salaries[i] * 0.02;
            }
            else
            {
                bonuses[i] = 0.0;
            }
            newSalaries[i] = salaries[i] + bonuses[i];
            totalbonus += bonuses[i];
            totalNewSalary += newSalaries[i];
            totalOldSalary += salaries[i];
        }
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus: " + totalbonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
}