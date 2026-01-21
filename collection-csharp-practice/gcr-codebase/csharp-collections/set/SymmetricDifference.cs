using System;
using System.Collections.Generic;

class SymmetricDifference
{
    public static void Main()
    {
        HashSet<int> set1=new HashSet<int>(){1,2,3};
        HashSet<int> set2=new HashSet<int>(){3,4,5};

        HashSet<int> Differance=new HashSet<int>();
        foreach(int i in set1)
        {
            if(!set2.Contains(i))
            {
                Differance.Add(i);
            }
        }
        foreach(int i in set2)
        {
            if(!set1.Contains(i))
            {
                Differance.Add(i);
            }
        }
        Console.WriteLine("\nSymmetric Difference");
        foreach(int i in Differance)
        {
            Console.Write(i+" ");
        }

    }
}