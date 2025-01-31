using System;
class Armstrong
			{
				static void Main()
				{
					//get the integer input
				Console.Write("Enter the input: ");
				int Number = int.Parse(Console.ReadLine());
				//initialise the sum as 0 
				int sum =0;
				//store the number to keep it unchanged
				int OriginalNumber = Number;
				//loop until the original number is 0
				while(OriginalNumber != 0)
				{
					//store the remainder
					
					int remainder = OriginalNumber%10;
					
					//finding the cube of digits
					sum+= (int)Math.Pow(remainder, 3);
					
					//updating the original number by removing the last digits
					OriginalNumber /= 10;
				}
				if(sum==Number)
				{
					Console.Write("Armstrong Number");
					
				}
				else{
					Console.Write("Not an Armstrong Number");
				}
				}
			}