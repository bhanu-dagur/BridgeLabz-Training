using System;
using System.Collections.Generic;

class FindSubsets
{
    public static void Main()
    {
        HashSet<int> set1=new HashSet<int>(){2,3};
        HashSet<int> set2=new HashSet<int>(){1,2,3,4};

        // if(set1.IsSubsetOf(set2))
        // {
        //     Console.WriteLine("set1 is a subset of set2");
        // }
        // else
        // {
        //     Console.WriteLine("set1 is not a subset of set2");
        // }


        // if(set1.IsSupersetOf(set2))
        // {
        //     Console.WriteLine("set1 is a superset of set2");
        // }
        // else
        // {
        //     Console.WriteLine("set1 is not a superset of set2");
        // }

        // Manualy find subsets and supersets
        bool ans=false;
        if (set1.Count > set2.Count)
        {

            HashSet<int>temp=set1;
            set1=set2;
            set2=temp;
        }

        foreach(int i in set1)
        {
            if(set2.Contains(i))
            {
                ans=true;
            }
            else
            {
                ans=false;
                break;
            }
        }
        
        if(ans)
        {
            Console.WriteLine("set1 is a subset of set2");
        }
        else
        {
            Console.WriteLine("set1 is not a subset of set2");
        }

    }
}