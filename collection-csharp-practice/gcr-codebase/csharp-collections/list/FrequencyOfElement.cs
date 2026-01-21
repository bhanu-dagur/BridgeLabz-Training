using System;
using System.Collections.Generic;

class FrequencyOfElement
{
    public static void Main()
    {
        List<string> list=new List<string>();
        Console.WriteLine("Enter the number of elements");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements");
        for(int i=0;i<n;i++)
        {
            string s=Console.ReadLine();
            list.Add(s);
        }

        FrequencyOfElement obj=new FrequencyOfElement();
        obj.CountElement(list);
    }

    public void CountElement(List<string> list)
    {
        Dictionary<string,int> dict=new Dictionary<string,int>();

        for(int i = 0; i < list.Count; i++)
        {
            if(dict.ContainsKey(list[i].ToLower()))
            {
                dict[list[i]]++;
            }
            else
            {
                dict.Add(list[i].ToLower(),1);
            }
        }

        // for(int i = 0; i < dict.Count; i++)
        // {
        //     Console.WriteLine("Frequency of {0} is {1}",dict.Keys[i],dict[list[i]]);
        // }

        foreach (var item in dict)
        {
            Console.WriteLine("Frequency of {0} is {1}",item.Key,item.Value);
        }

    }
}