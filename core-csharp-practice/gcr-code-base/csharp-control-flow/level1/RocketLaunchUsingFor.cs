using System;
class RocketLaunchUsingFor
{
    static void Main()
    {
        Console.WriteLine("Enter the Counter element: ");
        int counter=Convert.ToInt32(Console.ReadLine());
        for (; counter >= 1; counter--)
        {
            Console.WriteLine(counter);
        }
        Console.WriteLine("Rocket Launch");
    }
}