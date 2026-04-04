using System;

public class AadharMenu
{
    private AadharUtilityImpl utility;

    public AadharMenu(AadharUtilityImpl utility)
    {
        this.utility = utility;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n1. Display All Aadhar Records");
            Console.WriteLine("2. Sort Aadhar Records (Radix Sort)");
            Console.WriteLine("3. Search Aadhar Record");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.DisplayAll();
                    break;

                case 2:
                    utility.SortAadhar();
                    break;

                case 3:
                    Console.Write("Enter Aadhar number: ");
                    long key = long.Parse(Console.ReadLine());
                    utility.SearchAadhar(key);
                    break;

                case 4:
                    return;
            }
        }
    }
}
