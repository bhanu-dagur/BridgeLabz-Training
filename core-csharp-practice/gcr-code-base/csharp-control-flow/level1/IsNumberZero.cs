using System;
class IsNumberZero
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the Number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        if(number==0)   Console.WriteLine("zero");
        else if(number>0)   Console.WriteLine("positive");
        else  Console.WriteLine("negative");
    }
}