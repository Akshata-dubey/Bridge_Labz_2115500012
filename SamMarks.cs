using System;

class SamMarks

{

	static void Main()
	
	{
	
			//Marks obtained by Sam in each subject
			int mathsMarks = 94;
			int physicsMarks = 95;
			int chemistryMarks = 96;
			
			
			//Total marks for each subject
			int TotalMarks = 100;
			
			//Calculate the total marks obtained in all three subjects
			int totalMarksSub = mathsMarks + physicsMarks + chemistryMarks;
			
			//Calculate the total max marks for all three subjects
			int TotalMaxMarks = TotalMarks * 3;
			
			// Calculate the average percentage marks
           double averagePercentage = (double)totalMarksSub / TotalMaxMarks * 100;
			
			
			//output the result
			Console.WriteLine("Sam's average mark in PCM is" + averagePercentage.ToString("F2") + "%");
			}
		}