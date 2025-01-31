using System;

class RocketLaunch
{
    static void Main()
    {
        // Input: Get the countdown start value from the user
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        // While loop to count down from the input value to 1
        while (counter >= 1)
        {
            Console.WriteLine(counter);  // Print the current countdown value
            counter--;  // Decrement the counter
        }

        // Print the message when the countdown is complete
        Console.WriteLine("Rocket Launched!");
    }
}
