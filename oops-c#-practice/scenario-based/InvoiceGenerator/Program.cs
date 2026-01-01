using System;

class Program
{
    static void Main()
    {
        // Prompt user to enter invoice details
        Console.WriteLine("Enter invoice details:");
        Console.WriteLine("Eg: Logo Design - 3000 INR, Web Page - 4500 INR");

        // Read user input from console
        string input = Console.ReadLine();

        // Validate input using utility method
        // Prevents program from crashing on empty input
        if (InvoiceUtils.IsEmpty(input))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        // Create Invoice object with the provided input
        // Constructor splits input into individual tasks
        Invoice invoice = new Invoice(input);

        // Display each task with its amount
        invoice.DisplayInvoice();

        // Calculate total invoice amount
        int total = invoice.GetTotalAmount();

        // Display total amount
        Console.WriteLine("\nTotal Invoice Amount: ₹" + total);
    }
}
