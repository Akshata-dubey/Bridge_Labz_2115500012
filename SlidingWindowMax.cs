using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SlidingWindowMax
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums.Length == 0) return Array.Empty<int>();

        List<int> result = new();
        LinkedList<int> deque = new();

        for (int i = 0; i < nums.Length; i++)
        {
            while (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst();

            while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                deque.RemoveLast();

            deque.AddLast(i);

            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }
        return result.ToArray();
    }

    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        Console.WriteLine(string.Join(" ", MaxSlidingWindow(nums, k))); // Output: 3 3 5 5 6 7
    }
}
