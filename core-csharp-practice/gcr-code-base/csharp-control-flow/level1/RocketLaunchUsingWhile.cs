using System;
class RocketLaunchUsingWhile
{
    static void Main()
    {
        Console.WriteLine("Enter the Counter element: ");
        int counter=Convert.ToInt32(Console.ReadLine());
        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("Rocket Launch");
    }
}