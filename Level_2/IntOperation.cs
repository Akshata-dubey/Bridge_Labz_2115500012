using System;

class IntOperation
{
    static void Main()
    {
        // Input values for a, b, and c
        Console.Write("Enter the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        // Perform the integer operations
        int result1 = a + b * c;       // Multiplication (*) has higher precedence than addition (+)
        int result2 = a * b + c;       // Multiplication (*) has higher precedence than addition (+)
        int result3 = c + a / b;       // Division (/) has higher precedence than addition (+)
        int result4 = a % b + c;       // Modulus (%) has higher precedence than addition (+)

        // Print the results
        Console.WriteLine("The results of Int Operations are:");
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
