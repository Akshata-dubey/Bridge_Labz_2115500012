//Reversing a string without using pre defined string
using System;
class Reverse{
		static void Main()
		{	
			string str = "Akshata Dubey";
			string reversed = " ";
			
			for(int i = str.Length-1;i>=0;i--)
			{
			
				reversed += str[i]; 
			
			
			
			}
			Console.Write("Reversed String is: "+ reversed);
		
		
		
		}


}