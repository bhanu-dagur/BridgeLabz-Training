using System;
using System.Text;
using System.Diagnostics;

class CampareStringBuilderPerformance
{
    public static void Main()
    {

        Stopwatch sw = Stopwatch.StartNew();
        string str1="hello";
        int count=10000;

        for(int i = 0; i < count; i++)
        {
            str1=str1+"world";

        }
        sw.Stop();
        Console.WriteLine("String concetenate time: "+sw.ElapsedMilliseconds+"ms");
        
        sw.Reset();
        sw.Start();
        StringBuilder sb=new StringBuilder("hello");
        for(int i = 0; i < count; i++)
        {
            sb.Append("world");
        }
        sw.Stop();
        Console.WriteLine("StringBuilder concatenate time: "+sw.ElapsedMilliseconds+"ms");


    }
}