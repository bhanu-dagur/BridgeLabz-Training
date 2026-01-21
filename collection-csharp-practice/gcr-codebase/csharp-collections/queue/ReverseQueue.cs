using System;
using System.Collections.Generic;

class ReverseQueue
{
    public static void Main()
    {
        Queue<int> queue=new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        Console.WriteLine("Original Queue:");
        PrintQueue(queue);

        ToReverseQueue(queue);

        Console.WriteLine("\nReversed Queue:");
        PrintQueue(queue);
    }
    public static void ToReverseQueue(Queue<int> queue)
    {
        if(queue.Count==0)  return;

        int temp=queue.Dequeue();

        ToReverseQueue(queue);

        queue.Enqueue(temp);
    }
    public static void PrintQueue(Queue<int> queue)
    {
        foreach(int i in queue)
        {
            Console.Write(i+" ");
        }
    }
}