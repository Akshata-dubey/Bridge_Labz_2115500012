using System;

class RocketLaunchForLoop
{
    static void Main()
    {
        // Input: Get the countdown start value from the user
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // For loop to count down from the input value to 1
        for (int i = counter; i >= 1; i--)
        {
            Console.WriteLine(i);  // Print the current countdown value
        }

        // Print the message when the countdown is complete
        Console.WriteLine("Rocket Launched!");
    }
}
