using System;
class Abundant {
		static void Main(){
			
			//take the input from the user
			Console.Write("Enter the input number: ");
			int number = int.Parse(Console.ReadLine());
			//putting the number in another variable
			int originalNum = number;
			//initialise a sum as 0
			int sum = 0;
			//loop for numbers less than the number 
			for(int i =1;i<number;i++){
				//checking the divisibility
				if(number%i==0)
				{
				sum+=i;
				}
				
			
			}
			if(sum > originalNum)
			{
				Console.Write("Abundant");
			}
			else{
			Console.Write("Not Abundant");
			}
			
			
		
		}




}