using System;

class Pen
	{
		static void Main()
		{
		int TotalPens = 14;
		int TotalStudents = 3;
		
		//For finding the remaining noe distributed pens
		
		int RemainingPens = TotalPens%TotalStudents;
		
		//For finding the Total number of pens given to each student
		
		int DistributedPens = TotalPens/TotalStudents;
		
		Console.Write(The Pen Per Student is " + DistributedPens + "and the remaining pen not distributed is "+ RemainingPens);
		}
	}