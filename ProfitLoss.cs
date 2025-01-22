using System;

class ProfitLoss
{
    static void Main()
    {
        // Cost price and selling price
        double CP = 129;
        double SP = 191;

        // Calculate profit and profit percentage
        double profit = SP - CP;
        double profitPercentage = (profit / CP) * 100;

        // Output the result using a single print statement
        Console.WriteLine("The Cost Price is " + CP+ " and Selling Price is " + SP+
                          "\nThe Profit is " + profit + " and the Profit Percentage is " + profitPercentage.ToString("F2") + "%");
    }
}
