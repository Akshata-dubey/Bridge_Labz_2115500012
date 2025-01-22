using System;

class Discount
{
    static void Main()
    {
        // Course fee and discount percentage
        double fee = 125000;
        double discountPercent = 10;

        // Calculate discount amount
        double discount = (discountPercent / 100) * fee;

        // Calculate the final fee after discount
        double finalFee = fee - discount;

        // Output the results
        Console.WriteLine("The discount amount is INR " + discount + " and final discounted fee is INR " + finalFee);
    }
}
