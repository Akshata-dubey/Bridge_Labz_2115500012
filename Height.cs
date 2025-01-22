using System;

class Height
{
    static void Main()
    {
        // Ask the user to input their height in centimeters
        double heightCm;
        Console.Write("Enter your height in centimeters: ");
        heightCm = Convert.ToDouble(Console.ReadLine());

        // Convert centimeters to inches (1 inch = 2.54 cm)
        double heightInches = heightCm / 2.54;

        // Convert inches to feet (1 foot = 12 inches)
        int feet = (int)(heightInches / 12); // Divide by 12 to get the number of feet
        int inches = (int)(heightInches % 12); // Get the remainder as inches

        // Display the height in centimeters, feet, and inches
        Console.WriteLine("Your height in cm is " + heightCm + " while in feet is " + feet + " and inches is " + inches);
    }
}
