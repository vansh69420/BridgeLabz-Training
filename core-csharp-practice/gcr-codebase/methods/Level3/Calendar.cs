using System;

class Calendar
{
    // a. Method to get month name
    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                            "July", "August", "September", "October", "November", "December" };
        if (month < 1 || month > 12) return "Invalid Month";
        return months[month - 1];
    }

    // b. Leap year check
    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    // b. Get number of days in month
    public static int GetNumberOfDays(int month, int year)
    {
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 
                              31, 31, 30, 31, 30, 31 };
        if (month == 2 && IsLeapYear(year)) return 29;
        return daysInMonth[month - 1];
    }

    // c. Get first day of the month using Gregorian algorithm
    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + (31 * m0) / 12) % 7; // 1st day of the month
        return d0;
    }

    // f. Display the calendar
    public static void DisplayCalendar(int month, int year)
    {
        string monthName = GetMonthName(month);
        int daysInMonth = GetNumberOfDays(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine("\n     " + monthName + " " + year);
        Console.WriteLine("Su Mo Tu We Th Fr Sa");

        // e. First loop for indentation
        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("   ");
        }

        // f. Second loop to print the days
        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write(day.ToString().PadLeft(2) + " ");
            if ((firstDay + day) % 7 == 0)
                Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        DisplayCalendar(month, year);
    }
}
