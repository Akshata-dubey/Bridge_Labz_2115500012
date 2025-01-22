using System;

class DoubleOpt
{
    static void Main()
    {
        // Input values for a, b, and c as double
        Console.Write("Enter the value of a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Perform the double operations
        double result1 = a + b * c;       // Multiplication (*) has higher precedence than addition (+)
        double result2 = a * b + c;       // Multiplication (*) has higher precedence than addition (+)
        double result3 = c + a / b;       // Division (/) has higher precedence than addition (+)
        double result4 = a % b + c;       // Modulus (%) has higher precedence than addition (+)

        // Print the results
        Console.WriteLine("The results of Double Operations are:");
        Console.WriteLine("a + b * c = " + result1);
        Console.WriteLine("a * b + c = " + result2);
        Console.WriteLine("c + a / b = " + result3);
        Console.WriteLine("a % b + c = " + result4);

        // Note on precedence:
        Console.WriteLine("\nOperator Precedence:");
        Console.WriteLine("1. Parentheses ( )");
        Console.WriteLine("2. Multiplication (*), Division (/), Modulus (%)");
        Console.WriteLine("3. Addition (+), Subtraction (-)");
    }
}
