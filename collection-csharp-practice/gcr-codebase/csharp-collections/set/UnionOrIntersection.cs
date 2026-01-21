using System;
using System.Collections.Generic;
class UnionOrIntersection
{
    public static void Main()
    {
        HashSet<int> set1=new HashSet<int>(){1,2,3};
        HashSet<int> set2=new HashSet<int>(){3,4,5};

        HashSet<int> union=new HashSet<int>();
        foreach(int i in set1)
        {
            union.Add(i);
        } 

        foreach(int i in set2)
        {
            union.Add(i);
        }
        Console.WriteLine("Union");
        foreach(int i in union)
        {
            Console.Write(i+" ");
        }

        HashSet<int> intersection=new HashSet<int>();
        foreach(int i in set1)
        {
            if(set2.Contains(i))
            {
                intersection.Add(i);
            }
        }
        Console.WriteLine("\nIntersection");
        foreach(int i in intersection)
        {
            Console.Write(i+" ");
        }

    }
}
