using System;
using System.Collections;
using System.Collections.Generic;

class ReverseList
{
    public static void Main()
    {
        ReverseList obj = new ReverseList();

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add(4);
        arrayList.Add(5);

        Console.WriteLine("Original ArrayList:");
        foreach (int i in arrayList)
        {
            Console.Write(i + " ");
        }

        obj.ReverseArrayList(arrayList);

        Console.WriteLine("\nReversed ArrayList:");
        foreach (int i in arrayList)
        {
            Console.Write(i + " ");
        }

        LinkedList<int> list = new LinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(4);
        list.AddLast(5);

        Console.WriteLine("\n\nOriginal LinkedList:");
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }

        obj.ReverseLinkedList(ref list);

        Console.WriteLine("\nReversed LinkedList:");
        foreach (int i in list)
        {
            Console.Write(i + " ");
        }
    }

    public void ReverseArrayList(ArrayList arrayList)
    {
        int i = 0;
        int j = arrayList.Count - 1;

        while (i < j)
        {
            object temp = arrayList[i];
            arrayList[i] = arrayList[j];
            arrayList[j] = temp;
            i++;
            j--;
        }
    }

    public void ReverseLinkedList(ref LinkedList<int> list)
    {
        LinkedList<int> reversed = new LinkedList<int>();
        foreach (int i in list)
        {
            reversed.AddFirst(i);
        }
        list = reversed;
    }
}
