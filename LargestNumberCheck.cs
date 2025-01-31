using System;

class LargestNumberCheck
{
    static void Main()
    {
        // Input: Get three numbers from the user
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());

        // Check if the first number is the largest
        bool isFirstLargest = (number1 > number2) && (number1 > number3);

        // Check if the second number is the largest
        bool isSecondLargest = (number2 > number1) && (number2 > number3);

        // Check if the third number is the largest
        bool isThirdLargest = (number3 > number1) && (number3 > number2);

        // Output the results
        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}
