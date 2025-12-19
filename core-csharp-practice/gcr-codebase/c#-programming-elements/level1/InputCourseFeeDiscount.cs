using System;

class InputCourseFeeDiscount
{
    static void Main()
    {
        int fee = Convert.ToInt32(Console.ReadLine());
        int discountPercent = Convert.ToInt32(Console.ReadLine());

        double discount = fee * discountPercent / 100.0;
        double finalFee = fee - discount;

        Console.WriteLine(
            "The discount amount is INR " + discount +
            " and final discounted fee is INR " + finalFee
        );
    }
}