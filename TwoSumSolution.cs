using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TwoSumSolution
{
    public static int[] TwoSum(int[] arr, int target)
    {
        Dictionary<int, int> numIndex = new();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];

            if (numIndex.ContainsKey(complement))
                return new int[] { numIndex[complement], i };

            numIndex[arr[i]] = i;
        }
        return Array.Empty<int>();
    }

    public static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(arr, target);
        Console.WriteLine(result.Length > 0 ? $"Indices: {result[0]}, {result[1]}" : "No solution");
    }
}
