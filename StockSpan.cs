using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] spans = new int[n];
        Stack<int> stack = new();

        for (int i = 0; i < n; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
                stack.Pop();

            spans[i] = stack.Count == 0 ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }
        return spans;
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] spans = CalculateSpan(prices);
        Console.WriteLine(string.Join(" ", spans)); // Output: 1 1 1 2 1 4 6
    }
}
