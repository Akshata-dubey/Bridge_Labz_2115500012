using System;
class Palindrome{

		static void Main(){
		
				Console.Write("Enter the string: ");
				string input = Console.ReadLine();
				
				bool isPalindrome = true;
				
				int left =0, right = input.Length-1;
			    
				//Compare characters from both ends
				while(left <right)
				{
					if(input[left] != input[right])
					{
						isPalindrome = false;
						break;
						
					}
					left++;
					right--;
				
				
				
				
				}
				//output result
				
				if(isPalindrome)
					Console.WriteLine("The string is a palindrome");
				else
					Console.WriteLine("The string is a not a palindrome");
		
		
		}




}