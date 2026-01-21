using System;
using System.Collections.Generic;

class SortedList
{
    public static void Main()
    {
        HashSet<int> set=new HashSet<int>();
        set.Add(24);
        set.Add(22);
        set.Add(25);
        set.Add(23);
        set.Add(21);

        ConvertToSortedList(set);
    }
    public static void ConvertToSortedList(HashSet<int> set)
    {
        List<int> list=new List<int>(set);
        list.Sort();

        foreach(int i in list)
        {
            Console.Write(i+" ");
        }
    }
}