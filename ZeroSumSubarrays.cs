using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ZeroSumSubarrays
{
    public static void FindZeroSumSubarrays(int[] arr)
    {
        Dictionary<int, List<int>> sumIndices = new();
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];

            if (sum == 0)
                Console.WriteLine($"Subarray [0, {i}]");

            if (sumIndices.ContainsKey(sum))
            {
                foreach (int startIndex in sumIndices[sum])
                    Console.WriteLine($"Subarray [{startIndex + 1}, {i}]");
            }

            if (!sumIndices.ContainsKey(sum))
                sumIndices[sum] = new List<int>();

            sumIndices[sum].Add(i);
        }
    }

    public static void Main()
    {
        int[] arr = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
        FindZeroSumSubarrays(arr);
    }
}
