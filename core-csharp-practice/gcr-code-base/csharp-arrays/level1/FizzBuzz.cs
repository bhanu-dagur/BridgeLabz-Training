using System;

class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        string[] result = new string[number+1];

        // fill array with String 
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                result[i-1] = "FizzBuzz";
            else if (i % 3 == 0)
                result[i-1] = "Fizz";
            else if (i % 5 == 0)
                result[i-1] = "Buzz";
            else
                result[i-1] = i.ToString();
        }

        // Printing array results
        for (int i = 0; i <number; i++)
        {
            Console.WriteLine("Position " + (i+1) + " = " + result[i]);
        }
    }
}
