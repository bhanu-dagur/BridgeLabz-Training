using System;
class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter the number of the terms");
        int term=Convert.ToInt32(Console.ReadLine());
        FindFibonacci(term);

    }
    static void FindFibonacci(int n)
    {
        int firstTerm=0;
        int secondTerm=1;
        for(int i = 2; i < n; i++)
        {
            Console.Write(firstTerm);
            Console.Write(secondTerm);
            firstTerm=secondTerm;
            secondTerm=firstTerm+secondTerm;
        }
    }
}