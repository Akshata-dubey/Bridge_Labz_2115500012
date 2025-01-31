using System;

class Alphabets{

		static void Main(){
					
				Console.Write("Enter the string: ");
				string input = Console.ReadLine();
				
				int vowelCount =0 , consonantCount =0;
				
				char[] vowel = {'a','e','i','o','u','A','E','I','O','U'};
				
				for(int i=0;i<input.Length;i++)
				{
					char ch = input[i];
					
						
					
						if((ch>='A' && ch<='Z')||(ch>='a' && ch<='z'))
						{	
						
							bool isvowel = false;
							for(int j=0;j<vowel.Length;j++)
							{
								if(ch==vowel[j])
								{
								
									isvowel = true;
									
								
								
								}
							
							
							
							}
						
						if(isvowel)
						vowelCount++;
						else
						consonantCount++;
						
						
						}
						
				
					
					
					
				
				
				
				}
				Console.WriteLine("Vowel - "+ vowelCount);		
				Console.WriteLine("Consonant - "+ consonantCount);		
		
		
		}





}