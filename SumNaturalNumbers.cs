using System;

class SumNaturalNumbers
{
    static void Main()
    {
        // Prompt the user to enter a number
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Check if the number is a natural number
        if (n > 0)
        {
            // Compute the sum using the formula n * (n + 1) / 2
            int sumFormula = n * (n + 1) / 2;

            // Compute the sum using a while loop
            int sumLoop = 0;
            int i = 1;

            while (i <= n)
            {
                sumLoop += i;
                i++;
            }

            // Display both results
            Console.WriteLine("Sum using formula: " + sumFormula);
            Console.WriteLine("Sum using while loop: " + sumLoop);

            // Compare the two results
            if (sumFormula == sumLoop)
            {
                Console.WriteLine("The results match! Both computations are correct.");
            }
            else
            {
                Console.WriteLine("The results do not match. There may be an error.");
            }
        }
        else
        {
            // If the input is not a natural number, display a message
            Console.WriteLine("The number " + n + " is not a natural number.");
        }
    }
}
