using System;

// This class is responsible ONLY for cafeteria-related data and logic
class Cafeteria
{
    // Fixed list of menu items (array because items are fixed)
    private string[] menuItems =
    {
        "Veg Sandwich",
        "Cheese Burger",
        "Pasta",
        "Pizza Slice",
        "French Fries",
        "Cold Coffee",
        "Tea",
        "Samosa",
        "Noodles",
        "Fruit Juice"
    };

    // Displays all menu items with index numbers
    public void DisplayMenu()
    {
        Console.WriteLine("\n--- Cafeteria Menu ---");

        // Loop through array and print items
        for (int i = 0; i < menuItems.Length; i++)
        {
            Console.WriteLine($"{i}. {menuItems[i]}");
        }
    }

    // Returns item name based on index
    public string GetItemByIndex(int index)
    {
        // Validation to prevent runtime error
        if(index < 0 || index >= menuItems.Length)
        {
            return "Invalid Item Selection";
        }

        // Return valid menu item
        return menuItems[index];
    }
}
