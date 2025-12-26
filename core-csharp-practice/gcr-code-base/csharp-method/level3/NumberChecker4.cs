using System;

class NumberChecker4
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

    // b. Method to reverse digits array
    public static int[] ReverseArray(int[] array)
    {
        int[] reversed = new int[array.Length];
        int index = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversed[index++] = array[i];
        }
        return reversed;
    }

    // c. Method to compare two arrays
    public static bool AreArraysEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
            return false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }

    // d. Method to check Palindrome number
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed = ReverseArray(digits);
        return AreArraysEqual(digits, reversed);
    }

    // e. Method to check Duck Number
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

        int[] reversed = ReverseArray(digits);

        Console.Write("Reversed Array: ");
        foreach (int d in reversed)
        {
            Console.Write(d + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Arrays Equal: " + AreArraysEqual(digits, reversed));
        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits));
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
    }
}
