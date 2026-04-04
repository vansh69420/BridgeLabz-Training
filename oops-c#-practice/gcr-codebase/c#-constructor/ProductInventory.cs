
using System;

class ProductInventory
{
    // Instance variables
    public string productName;
    public double price;

    // Class variable
    public static int totalProducts = 0;

    // Constructor
    public ProductInventory(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++;
    }

    // Instance method
    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: ₹" + price);
    }

    // Class method
    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products Created: " + totalProducts);
    }
}

class Program
{
    static void Main()
    {
        ProductInventory p1 = new ProductInventory("Laptop", 55000);
        ProductInventory p2 = new ProductInventory("Mouse", 1200);

        p1.DisplayProductDetails();
        Console.WriteLine();

        p2.DisplayProductDetails();
        Console.WriteLine();

        ProductInventory.DisplayTotalProducts();
    }
}
