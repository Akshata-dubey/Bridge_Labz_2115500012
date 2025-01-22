using System;

class Fee
{
    static void Main()
    {
        // Ask the user to enter the fee of the course
        double fee;
        Console.Write("Enter the student fee in INR: ");
        fee = Convert.ToDouble(Console.ReadLine());

        // Ask the user to enter the discount percentage
        double discountPercent;
        Console.Write("Enter the discount percentage: ");
        discountPercent = Convert.ToDouble(Console.ReadLine());

        // Calculate the discount amount based on the fee and the discount percentage
        double discount = (discountPercent / 100) * fee;

        // Calculate the final fee after applying the discount
        double finalFee = fee - discount;

        // Display the discount amount and the final fee to the user
        Console.WriteLine("The discount amount is INR " + discount.ToString("F2") + " and final discounted fee is INR " + finalFee.ToString("F2"));
    }
}
