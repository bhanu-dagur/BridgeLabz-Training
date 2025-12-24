 using System;
 class Table6To9
{
    static void Main()
    {
        int []multiple=new int [4];

        Console.WriteLine("Enter the number");
        int number=Convert.ToInt32(Console.ReadLine());

        int index=0;
        for(int i = 6; i <= 9; i++)
        {
           multiple[index]=number*(i);
           index++;
         
        }
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(number+" * " +(i+6)+" = "+ multiple[i]);
        }
    }
}