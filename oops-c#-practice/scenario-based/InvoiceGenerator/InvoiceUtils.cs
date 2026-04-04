// Utility class that contains helper methods
// These methods are reusable and do not depend on object state
class InvoiceUtils
{
    // Checks whether the given input string is null, empty, or only whitespace
    // Used for input validation before processing invoice data
    public static bool IsEmpty(string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }

    // Extracts numeric amount from a string like "3000 INR"
    // Returns 0 if extraction or conversion fails
    public static int ExtractAmount(string amountPart)
    {
        // Defensive check to avoid null or empty values
        if (string.IsNullOrWhiteSpace(amountPart))
            return 0;

        // Split the string by space
        // Example: "3000 INR" → ["3000", "INR"]
        string[] parts = amountPart.Trim().Split(' ');

        // Safety check: ensure array has at least one element
        if (parts.Length == 0)
            return 0;

        int amount;

        // TryParse is used to avoid runtime exceptions
        // It safely converts string to integer
        bool success = int.TryParse(parts[0], out amount);

        // If conversion succeeds, return amount; otherwise return 0
        return success ? amount : 0;
    }
}
