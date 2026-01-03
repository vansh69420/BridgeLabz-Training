using System;

class Product
{
    public static double Discount = 10;

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

    public Product(int id, string name, double price, int quantity)
    {
        this.ProductID = id;
        this.ProductName = name;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
        Console.WriteLine("Discount: " + Discount + "%");
    }

    public void Display(object obj)
    {
        if (obj is Product)
        {
            Console.WriteLine($"{ProductName} - ₹{Price}, Qty: {Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product(501, "Laptop", 60000, 1);
        Product p2 = new Product(502, "Mobile" , 61000, 2);
        Product.UpdateDiscount(15);
        p.Display(p);
        p2.Display(p2);
    }
}
