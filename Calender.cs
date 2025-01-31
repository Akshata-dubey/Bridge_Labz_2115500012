using System;
class DayOfWeekProgram{
		static void Main(string[] args){
		
		//checking if the number of arguments is correct
		if(args.Length != 3)
		{
			Console.WriteLine("Usage: DayOfWeek <month> <day> <year>");
			return;
		}
		//Parse command-line arguments
		//Month
		int m = int.Parse(args[0]);
		//DAY
		int d = int.Parse(args[1]);
		//Year
		int y = int.Parse(args[2]);
		
		//Formula Calculation
		
		int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;
		
		//output
		Console.WriteLine(d0);
		
			
		
		}



}