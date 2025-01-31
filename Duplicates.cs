using System;
class Duplicate{

		static void Main()
		{
			Console.Write("Enter the string: ");
			string input = Console.ReadLine();
			
			
			string result = RemoveDuplicates(input);
			Console.WriteLine("String after removing duplicates"+ result);
		
		
		
		
		}
		static string RemoveDuplicates(string str)
		{
		//array to store unique arrays
		char[] unique = new char[str.Length];
		int index =0;
		
		for(int i=0;i<str.Length;i++)
		{
			bool isDuplicate = false;
			
			for(int j=0;j<index;j++)
			{
				if(str[i] == unique[j])
				{
					isDuplicate = true;
					break;
				
				
				
				}
			
			
			
			}
			if(!isDuplicate)
			 {
                unique[index] = str[i];
                index++;
            }
			
		
		
		
		}
		 // Convert uniqueChars array to string
        return new string(unique, 0, index);
		
		
		
		
		
		}




}