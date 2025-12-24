using System;

class FactorsOfNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxFactor = 10;                 
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                // Check if array is full
                if (index == maxFactor)
                {
                    // Double the size
                    maxFactor = maxFactor * 2;
                    int[] temp = new int[maxFactor];

                    // Copy old elements to new array
                    for (int j = 0; j < index; j++)
                    {
                        temp[j] = factors[j];
                    }

                    factors = temp;
                }

                factors[index] = i;
                index++;
            }
        }

        Console.WriteLine("Factors of " + number + " are:");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
}
