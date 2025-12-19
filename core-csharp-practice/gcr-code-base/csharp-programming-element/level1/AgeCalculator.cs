using System;
class AgeCalculator
{
    public static void Main (string [] args)
    {
        int birthYear=Convert.ToInt32(Console.ReadLine());
        if (birthYear < 2024)
        {
            int age=2024-birthYear;
            Console.WriteLine("Harry's age in 2024 is" +age);
        }
        else
        {
            Console.WriteLine("Enter valid input");
        }

    }
}