using System;
using System.Reflection.Metadata;
class MeanHeightOfPlayer
{
    static void Main()
    {
        double [] height=new double[11];
        Console.WriteLine("Enter the height of the football Players ");

        double sum=0.0;
        for(int i = 0; i < 11; i++)
        {
            height[i]=Convert.ToInt32(Console.ReadLine());
            sum+=height[i];
        }
        double mean=sum/11;
        Console.WriteLine("Mean heigh of the football team is "+mean);

    }
}