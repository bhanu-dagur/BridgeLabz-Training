using System;
using System.Collections.Generic;
class QueueUsingStack
{
    Stack<int> stackEnq=new Stack<int>();
    Stack<int> stackDeq=new Stack<int>();

    // Enqueue operation
    public void Enqueue(int data)
    {
        stackEnq.Push(data);
    }


    // Dequeue Operation
    public void Dequeue()
    {
        if (stackEnq.Count == 0 && stackDeq.Count==0)
        {
            return;
        }
        if(stackDeq.Count == 0)
        {
            while (stackEnq.Count != 0)
            {
                stackDeq.Push(stackEnq.Pop());
            }
        }
        Console.WriteLine(stackDeq.Pop());
        return;
    }
    public void Display()
    {
        if (stackEnq.Count == 0 && stackDeq.Count==0)
        {
            return;
        }
        if (stackDeq.Count == 0)
        {
            while (stackEnq.Count != 0)
            {
                stackDeq.Push(stackEnq.Pop());
            }
        }
        while (stackDeq.Count != 0)
        {
            Console.WriteLine(stackDeq.Peek());
        }
        return;
    }
    public void Peek()
    {
        if (stackEnq.Count == 0 && stackDeq.Count==0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }
        if (stackDeq.Count == 0)
        {
            while (stackEnq.Count != 0)
            {
                stackDeq.Push(stackEnq.Pop());
            }
        }
        Console.WriteLine("Peak element is: "+stackDeq.Pop());
        return;
    }
    public bool IsEmpty()
    {
        if(stackEnq.Count==0 && stackDeq.Count == 0)
        {
            return true;
        }
        return false;
    }
    
}
class ImplementQueue
{
    public static void Main()
    {
        QueueUsingStack queue=new QueueUsingStack();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        // queue.Display();
        queue.Dequeue();
        queue.Dequeue();
        queue.Peek();
        queue.Display();
    }
}