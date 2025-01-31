using System;
class SwitchCalculator
{		
			static void Main()
			{
			//taking the input values
			Console.Write("Enter the first number: ");
			double first = double.Parse(Console.ReadLine());
			Console.Write("Enter the second number: ");
			double second = double.Parse(Console.ReadLine());
			
			//input the operator
			Console.Write("Enter the Operator between +,-,*,/");
			String op = Console.ReadLine();
			
			//Using Switch Statement
			switch (op)
			{
			
			case "+": 
			
			Console.Write((first+second) + "is the answer");
			break;
			
			case "-":
			Console.Write((first-second) + "is the answer");
			break;
			
			case "*":
			Console.Write((first*second) + "is the answer");
			break;
			
			 case "/":
                if (second != 0)
                {
                    Console.WriteLine("Result: " + first + " / " + second + " = " + (first / second));
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
				
			 default:
                Console.WriteLine("Invalid Operator. Please use +, -, *, or /.");
                break;
			
			
			
			
			
			
			
			
			
			
			}
			
			
			
			}

}