using System;

class Invoice
{
    // Stores individual task strings after splitting input
    // Example: ["Logo Design - 3000 INR", " Web Page - 4500 INR"]
    private string[] tasks;

    // Constructor initializes the invoice with user input
    // Splits the input string into tasks using comma delimiter
    public Invoice(string input)
    {
        tasks = input.Split(',');
    }

    // Displays each task with its parsed name and amount
    public void DisplayInvoice()
    {
        Console.WriteLine("\n--- Invoice Details ---");

        for(int i = 0; i < tasks.Length; i++)
        {
            string name;
            int amount;

            // Parse task to extract name and amount
            ParseTask(tasks[i], out name, out amount);

            // Display formatted output
            Console.WriteLine($"{i + 1}. {name} : ₹{amount}");
        }
    }

    // Calculates the total invoice amount by summing task amounts
    public int GetTotalAmount()
    {
        int total = 0;

        for(int i = 0; i < tasks.Length; i++)
        {
            string name;
            int amount;

            // Reuse parsing logic
            ParseTask(tasks[i], out name, out amount);

            total += amount;
        }
        return total;
    }

    // Parses a single task string
    // Example: "Logo Design - 3000 INR"
    // Extracts task name and numeric amount
    private void ParseTask(string task, out string taskName, out int amount)
    {
        // Initialize output parameters
        taskName = "";
        amount = 0;

        // Defensive check for invalid task input
        if (string.IsNullOrWhiteSpace(task))
            return;

        // Split task using '-' delimiter
        // Expected format: TaskName - Amount INR
        string[] parts = task.Split('-');

        // Validate task format
        if (parts.Length < 2)
        {
            Console.WriteLine("Invalid task format: " + task);
            return;
        }

        // Extract and clean task name
        taskName = parts[0].Trim();

        // Extract numeric amount using utility method
        amount = InvoiceUtils.ExtractAmount(parts[1]);
    }
}
