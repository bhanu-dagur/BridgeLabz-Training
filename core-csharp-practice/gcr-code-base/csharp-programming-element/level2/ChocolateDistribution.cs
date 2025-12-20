using System;

class ChocolateDistribution
{
    static void Main()
    {
        int chocolates,  children;
        int chocolatesPerChild, remainingChocolates;

        Console.Write("Enter number of chocolates: ");
        chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        children = Convert.ToInt32(Console.ReadLine());

        chocolatesPerChild = chocolates /  children;
        remainingChocolates = chocolates %  children;

        Console.WriteLine(
            "The number of chocolates each child gets is " +
            chocolatesPerChild +
            " and the number of remaining chocolates is " +
            remainingChocolates
        );
    }
}
