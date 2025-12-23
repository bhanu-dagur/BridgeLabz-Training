using System;
using System.Reflection.Metadata;
class table
{
    static void Main()
    {
        Console.WriteLine("Enter the number between 6 to 9");
        int number=int.Parse(Console.ReadLine());

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(number+"*"+i+"="+number*i);
        }
    }
}