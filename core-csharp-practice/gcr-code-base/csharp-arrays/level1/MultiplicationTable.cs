 using System;
 class MultiplicationTable
{
    static void Main()
    {
        int []multiple=new int [10];
        Console.WriteLine("Enter the number");
        int number=Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < multiple.Length; i++)
        {
           multiple[i]=number*(i+1);
         
        }
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(number+" * " +(i+1)+" = "+multiple[i]);
        }
    }
}