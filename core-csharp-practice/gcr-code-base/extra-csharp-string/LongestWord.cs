using System;
using System.Runtime.CompilerServices;
class LongestWord
{
    static void Main()
    {
        Console.WriteLine("Give the sentance");
        String s=Console.ReadLine();

        String [] arr=s.Split(' ');
        int max=0;
        string ans="";
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length > max)
            {
                max=arr[i].Length;
                ans=arr[i];

            }
            
        }
        Console.WriteLine("longest word in the sentance is: "+ans +" and length is: "+max);
    }
}