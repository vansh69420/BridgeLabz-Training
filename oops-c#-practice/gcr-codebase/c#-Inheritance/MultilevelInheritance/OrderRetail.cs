using System;

class Order
{
    public virtual string GetOrderStatus()
    {
        return "Order Placed";
    }
}

class ShippedOrder : Order
{
    public override string GetOrderStatus()
    {
        return "Order Shipped";
    }
}

class DeliveredOrder : ShippedOrder
{
    public override string GetOrderStatus()
    {
        return "Order Delivered";
    }
}

class Program
{
    static void Main()
    {
        Order o1 = new Order();
        Order o2 = new ShippedOrder();
        Order o3 = new DeliveredOrder();

        Console.WriteLine(o1.GetOrderStatus());
        Console.WriteLine(o2.GetOrderStatus());
        Console.WriteLine(o3.GetOrderStatus());
    }
}
