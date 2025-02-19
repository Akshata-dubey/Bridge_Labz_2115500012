using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QueueUsingStacks
{
    private Stack<int> stack1 = new();
    private Stack<int> stack2 = new();

    public void Enqueue(int item)
    {
        stack1.Push(item);
    }

    public int Dequeue()
    {
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            while (stack1.Count > 0)
                stack2.Push(stack1.Pop());
        }
        return stack2.Pop();
    }

    public static void Main()
    {
        QueueUsingStacks q = new();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        Console.WriteLine(q.Dequeue()); // 1
        Console.WriteLine(q.Dequeue()); // 2
    }
}
