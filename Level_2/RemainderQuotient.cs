using System;

class RemainderQuotient
{
    static void Main()
    {
        // Ask the user to input the first number
        Console.Write("Enter the first number (dividend): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        // Ask the user to input the second number
        Console.Write("Enter the second number (divisor): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the quotient using division operator
        int quotient = number1 / number2;

        // Calculate the remainder using modulus operator
        int remainder = number1 % number2;

        // Display the results
        Console.WriteLine("The Quotient is " + quotient + " and Remainder is " + remainder + 
                          " of two numbers " + number1 + " and " + number2 + ".");
    }
}
