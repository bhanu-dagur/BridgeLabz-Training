using System;

class CountEachDigit
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int count = 0;

        //  Count digits
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        //  Store digits in array
        int[] digits = new int[count];
        temp = number;
        int index = 0;

        while (temp != 0)
        {
            digits[index++] = temp % 10;
            temp /= 10;
        }
        
        //Frequency array
        int[] frequency = new int[10];

        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i]]++;
        }

        // Step 4: Display frequency
        Console.WriteLine("\nDigit Frequency:");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i] > 0)
            {
                Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " times");
            }
        }
    }
}
