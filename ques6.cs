				Self-Practise			

Q6.Write a program to calculate simple interest using the formula:
Simple Interest = (Principal * Rate * Time) / 100.
Take Principal, Rate, and Time as inputs from the user.
Ans 
using System;
class SimpleInterest
{
    static void Main(string[] args)
    {
        Console.Write("Enter the Principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the Rate of Interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the Time (in years): ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is: {simpleInterest}");
    }
}
