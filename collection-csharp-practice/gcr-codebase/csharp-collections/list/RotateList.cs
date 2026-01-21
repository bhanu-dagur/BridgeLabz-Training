using System;
using System.Collections.Generic;

class RotateList
{
    public static void Main()
    {
        Console.WriteLine("Enter the size of the list");
        int size=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the elements of the list");
        List<int> list=new List<int>();
        for(int i=0;i<size;i++)
        {
            list.Add(Convert.ToInt32(Console.ReadLine()));
        }

        Console.WriteLine("Enter the value of k");
        int k=Convert.ToInt32(Console.ReadLine());

        RotateList obj=new RotateList();
        obj.Rotate(list,k);

        foreach(int i in list)
        {
            Console.Write(i+" ");
        }
    }
    public void Rotate(List<int> list, int k)
    {
        List<int> result=new List<int>();
        for(int i = k; i < list.Count + k; i++)
        {
            result.Add(list[i%list.Count]);

        }

        list.Clear();
        list.AddRange(result);  

    }
}