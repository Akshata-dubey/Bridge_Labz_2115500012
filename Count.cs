using System;
class Count{
				static void Main()
				{
					//take the input value
					Console.Write("Enter the input value: ");
					int number = int.Parse(Console.ReadLine());
					//variable to count the digits
					int count =0;
					//storing the original number without changing
					int originalNumber = number;
					//iterating till the number is not 0
					while(originalNumber!=0)
					{
						//extracting the last digit
						int remainder = originalNumber%10;
						// counting
						count++;
						//updating the original number
						originalNumber /= 10;
						
					}
					//printing
					Console.Write("The total number of digits in the number are: "+count);
					
					
				
				
				
				}
				}