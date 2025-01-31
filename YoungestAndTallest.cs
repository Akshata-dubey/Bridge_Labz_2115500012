using System;

class YoungestAndTallest
{
    static void Main()
    {
        // Input for Amar's age and height
        Console.Write("Enter Amar's age: ");
        int amarAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Amar's height (in cm): ");
        double amarHeight = double.Parse(Console.ReadLine());

        // Input for Akbar's age and height
        Console.Write("Enter Akbar's age: ");
        int akbarAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Akbar's height (in cm): ");
        double akbarHeight = double.Parse(Console.ReadLine());

        // Input for Anthony's age and height
        Console.Write("Enter Anthony's age: ");
        int anthonyAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Anthony's height (in cm): ");
        double anthonyHeight = double.Parse(Console.ReadLine());

        // Determine the youngest friend
        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        string youngestFriend = "";

        if (youngestAge == amarAge) youngestFriend = "Amar";
        else if (youngestAge == akbarAge) youngestFriend = "Akbar";
        else youngestFriend = "Anthony";

        // Determine the tallest friend
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));
        string tallestFriend = "";

        if (tallestHeight == amarHeight) tallestFriend = "Amar";
        else if (tallestHeight == akbarHeight) tallestFriend = "Akbar";
        else tallestFriend = "Anthony";

        // Output the results
        Console.WriteLine($"{youngestFriend} is the youngest with age {youngestAge}.");
        Console.WriteLine($"{tallestFriend} is the tallest with height {tallestHeight} cm.");
    }
}
