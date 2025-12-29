using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter the number of terms:");
        int n = Convert.ToInt32(Console.ReadLine());

        FindFibonacci(n);
    }

    static void FindFibonacci(int n)
    {
        int first = 0;
        int second = 1;

        if (n >= 1)
            Console.Write(first + " ");

        if (n >= 2)
            Console.Write(second + " ");

        for (int i = 3; i <= n; i++)
        {
            int next = first + second;
            Console.Write(next + " ");

            first = second;
            second = next;
        }
    }
}
