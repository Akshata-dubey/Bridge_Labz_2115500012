Q8.Write a program that takes two numbers as input: a base and an exponent,
and prints the result of base raised to the exponent (without using loops or
conditionals).
Ans 
using System;
class PowerCalculation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the base: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.Write("Enter the exponent: ");
        double exponent = double.Parse(Console.ReadLine());
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"{baseNum} raised to the power of {exponent} is: {power}");
    }
}
