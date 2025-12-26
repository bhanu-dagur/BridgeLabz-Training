using System;

class NumberChecker2
{
    // a. Method to find count of digits
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

    // b. Method to store digits in array
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
    // Duck number: contains at least one non-zero digit
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }

    // d. Method to check Armstrong Number
    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int power = digits.Length;
        int sum = 0;

        foreach (int d in digits)
        {
            sum += (int)Math.Pow(d, power);
        }
        return sum == number;
    }

    // e. Method to find largest and second largest
    public static void FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                secondLargest = largest;
                largest = d;
            }
            else if (d > secondLargest && d != largest)
            {
                secondLargest = d;
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second Largest digit: " + secondLargest);
    }

    // f. Method to find smallest and second smallest
    public static void FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if (d < secondSmallest && d != smallest)
            {
                secondSmallest = d;
            }
        }

        Console.WriteLine("Smallest digit: " + smallest);
        Console.WriteLine("Second Smallest digit: " + secondSmallest);
    }

    // MAIN METHOD
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = GetDigitsArray(number);

        Console.WriteLine("Digit Count: " + digitCount);

        Console.Write("Digits Array: ");
        foreach (int d in digits)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number, digits));

        FindLargestAndSecondLargest(digits);
        FindSmallestAndSecondSmallest(digits);
    }
}
