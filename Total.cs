using System;

class TotalPrice
{
    static void Main()
    {
        // Ask the user to input the unit price of the item
        Console.Write("Enter the unit price of the item (in INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());

        // Ask the user to input the quantity of items to be purchased
        Console.Write("Enter the quantity of items to be purchased: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        // Calculate the total price
        double totalPrice = unitPrice * quantity;

        // Display the result
        Console.WriteLine("The total purchase price is INR " + totalPrice.ToString("F2") + 
                          " if the quantity is " + quantity + 
                          " and the unit price is INR " + unitPrice.ToString("F2") + ".");
    }
}
