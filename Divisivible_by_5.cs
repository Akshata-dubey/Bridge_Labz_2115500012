using System;
class Divisible_by_5
{

	static void Main()
	{
		//taking the input
		Console.Write("Enter the input number: ");
		int number = int.Parse(Console.ReadLine());
		
		//checking the divisibility
		if(number%5==0)
		Console.Write("Divisible by 5");
		else
		Console.Write("Not Divisible by 5");
	
	
	}



}