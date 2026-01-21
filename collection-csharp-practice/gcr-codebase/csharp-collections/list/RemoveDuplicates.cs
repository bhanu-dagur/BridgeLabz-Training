using System;
using System.Collections.Generic;
using System.Linq;

class RemoveDuplicates
{
    public static void Main()
    {
        List<int>list=new List<int>();

        Console.WriteLine("Enter the number of elements");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements");
        for(int i=0;i<n;i++)
        {
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Removes(list);

        foreach(int i in list)
        {
            Console.Write(i+" ");
        }


        
    }
    public static void Removes(List<int> list)
    {
        Dictionary<int,int> dict=new Dictionary<int,int>();

        foreach (var i in list)
        {
            if(dict.ContainsKey(i))
            {
                dict[i]++;
            }
            else
            {
                dict.Add(i,1);
            }
        }

        foreach (var item in dict)
        {
            if(item.Value>1)
            {
                list.Remove(item.Key);
            }
        }
    }
}