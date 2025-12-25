using System;

class SumOfNaturalNum
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Please enter a valid natural number.");
            return;
        }

        int recursiveSum = SumUsingRecursion(n);
        int formulaSum = SumUsingFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula " + formulaSum);

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("Both results are correct and equal.");
        }
        else
        {
            Console.WriteLine("Results are not equal.");
        }
    }

    // find sum using recursion
    static int SumUsingRecursion(int n)
    {
        if (n == 1)
            return 1;
        return n + SumUsingRecursion(n - 1);
    }

    
    static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }
}
