class LoanMain
{
    static void Main()
    {
        Menu menu = new Menu();
        menu.ShowMenu();

        int choice = int.Parse(Console.ReadLine());
        if (choice != 1) return;

        Applicant applicant = new Applicant();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Credit Score: ");
        int score = int.Parse(Console.ReadLine());

        Console.Write("Income: ");
        double income = double.Parse(Console.ReadLine());

        Console.Write("Loan Amount: ");
        double amount = double.Parse(Console.ReadLine());

        applicant.SetData(name, score, income, amount);

        Console.Write("Loan Type (Personal/Home/Auto): ");
        string type = Console.ReadLine();

        Console.Write("Loan Term (months): ");
        int term = int.Parse(Console.ReadLine());

        LoanUtilityImpl loan = new LoanUtilityImpl();
        loan.SetLoanDetails(type);

        bool approved = loan.ApproveLoan(applicant);

        Console.WriteLine("\n--- Applicant Details ---");
        Console.WriteLine(applicant);

        Console.WriteLine("\n--- Loan Details ---");
        Console.WriteLine(loan);
        if (approved)
        {
            double emi = loan.CalculateEMI(amount, loan.GetRate(), term);
            Console.WriteLine("\nMonthly EMI: " + Math.Round(emi, 2));
        }
    }
}
