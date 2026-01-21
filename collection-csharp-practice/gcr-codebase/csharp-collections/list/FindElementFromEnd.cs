using System;
using System.Collections.Generic;
using System.Linq;
class FindElementFromEnd
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the list");
        int size = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements of the list");
        LinkedList<int> list = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            list.AddLast(Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Enter the nth element you want to find from the end");
        FindNthElement(list, Convert.ToInt32(Console.ReadLine()));

    }
    static void FindNthElement(LinkedList<int> list, int n)
    {
       LinkedListNode<int> fast = list.First;
       LinkedListNode<int> slow = list.First;

       for(int i = 0; i < n; i++)
        {
            fast = fast.Next;
        }

        while(fast!= null)
        {
            fast = fast.Next;
            slow = slow.Next;
        } 

        Console.WriteLine("The element from the end is {0}", slow.Value);
    }
}