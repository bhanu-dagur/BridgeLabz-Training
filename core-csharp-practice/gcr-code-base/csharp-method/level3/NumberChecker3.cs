using System;

class NumberChecker3
{
    // a. Method to count digits
    public static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number = number / 10;
        }
        return count;
    }

    // a. Method to store digits in array
    public static int[] GetDigitsArray(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number = number / 10;
        }
        return digits;
    }

    // b. Method to find sum of digits
    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
        {
            sum += d;
        }
        return sum;
    }

    // c. Method to find sum of squares of digits
    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, 2);
        }
        return sum;
    }

    // d. Method to check Harshad number
    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return number % sum == 0;
    }

    // e. Method to find frequency of each digit
    public static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            freq[i, 0] = i;   // digit
            freq[i, 1] = 0;   // frequency
        }

        foreach (int d in digits)
        {
            freq[d, 1]++;
        }

        return freq;
    }

    // MAIN METHOD
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = GetDigitsArray(number);

        Console.Write("Digits Array: ");
        foreach (int d in digits)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Count of digits: " + CountDigits(number));
        Console.WriteLine("Sum of digits: " + SumOfDigits(digits));
        Console.WriteLine("Sum of squares of digits: " + SumOfSquaresOfDigits(digits));
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

        int[,] frequency = DigitFrequency(digits);

        Console.WriteLine("Digit  Frequency");
        for (int i = 0; i < 10; i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine(frequency[i, 0] + "      " + frequency[i, 1]);
            }
        }
    }
}
