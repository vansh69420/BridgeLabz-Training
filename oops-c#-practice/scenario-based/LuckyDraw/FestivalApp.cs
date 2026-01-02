using System;
class FestivalApp
{
    static void Main(string[] args)
    {
        LuckyDrawService luckyDraw = new LuckyDrawService();

        Console.WriteLine("🎉 Welcome to Diwali Lucky Draw 🎉");
        Console.WriteLine("Select Role:");
        Console.WriteLine("1. Organizer");
        Console.WriteLine("2. Visitor");

        int role = Convert.ToInt32(Console.ReadLine());

        switch(role)
        {
            case 1:
                OrganizerView();
                break;
            case 2:
                VisitorView(luckyDraw);
                break;
            default:
                Console.ReadLine();
                break;
        }

    }

    static void OrganizerView()
    {
        Console.WriteLine("\n Organizer Rules:");
        Console.WriteLine("- Number divisible by 3 AND 5 wins");
        Console.WriteLine("- Visitors can exit anytime");
    }

    static void VisitorView(LuckyDrawService luckyDraw)
    {
        while (true)
        {
            Console.Write("\nEnter lucky number (or type exit): ");

            int number;
            bool success = InputHelper.TryGetNumber(out number);

            if (!success && number == -1)
            {
                Console.WriteLine("Thank you for visiting the Diwali Mela!");
                break;
            }

            if (!success)
            {
                Console.WriteLine(" Invalid input. Try again.");
                continue;
            }

            if (luckyDraw.IsWinner(number))
            {
                Console.WriteLine(" Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine(" Better luck next time.");
            }
        }
    }
}