using System;

class ChocolateDivision
{
    static void Main()
    {
        // Input: Get the total number of chocolates
        Console.Write("Enter the total number of chocolates: ");
        int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

        // Input: Get the total number of children
        Console.Write("Enter the total number of children: ");
        int numberOfChildren = Convert.ToInt32(Console.ReadLine());

        // Calculate how many chocolates each child gets
        int chocolatesPerChild = numberOfChocolates / numberOfChildren;

        // Calculate the number of remaining chocolates
        int remainingChocolates = numberOfChocolates % numberOfChildren;

        // Output the results
        Console.WriteLine("The number of chocolates each child gets is " + chocolatesPerChild + 
                          " and the number of remaining chocolates is " + remainingChocolates + ".");
    }
}
