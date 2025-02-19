using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortStackRecursively
{
    public static void SortStack(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            SortStack(stack);
            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(Stack<int> stack, int item)
    {
        if (stack.Count == 0 || stack.Peek() <= item)
            stack.Push(item);
        else
        {
            int temp = stack.Pop();
            InsertSorted(stack, item);
            stack.Push(temp);
        }
    }

    public static void Main()
    {
        Stack<int> stack = new(new int[] { 3, 1, 4, 2 });
        SortStack(stack);
        while (stack.Count > 0)
            Console.Write(stack.Pop() + " "); // Output: 1 2 3 4
    }
}
