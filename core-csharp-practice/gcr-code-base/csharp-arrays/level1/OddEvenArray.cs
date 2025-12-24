using System;

class OddEvenArray
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Check Natural Number
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number");
            return;
        }

        // Array size
        int size = number / 2 + 1;

        int[] odd = new int[size];
        int[] even = new int[size];

        int oddIndex = 0;
        int evenIndex = 0;

        // Store odd and even numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                even[evenIndex++] = i;
            }
            else
            {
                odd[oddIndex++] = i;
            }
        }

        // Print Odd Numbers
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(odd[i] + " ");
        }

        // Print Even Numbers
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(even[i] + " ");
        }
    }
}
