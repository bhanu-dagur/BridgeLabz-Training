using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolate = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());

        int[] result = DistributeChocolates(chocolate, children);

        Console.WriteLine("Each child gets: " + result[0]);
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    public static int[] DistributeChocolates(int chocolate, int children)
    {
        int perChildren = chocolate / children;
        int remaining = chocolate % children;

        return new int[] { perChildren, remaining };
    }
}
