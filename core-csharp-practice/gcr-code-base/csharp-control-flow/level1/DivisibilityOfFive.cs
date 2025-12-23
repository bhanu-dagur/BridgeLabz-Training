using System;
class DivisibilityOfFive
{
    public static void Main(string[] args)
    {
        int number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is the number "+ number +" is divisible by 5? ");
        if (number % 5 == 0)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No ");
        }
    }
}