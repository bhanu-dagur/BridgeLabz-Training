using System;

class NumberChecker5
{
    public static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= number / 2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // b. Method to check Neon Number
    // Neon=>sum of digits of square == number
    public static bool IsNeon(int number)
    {
        int square = number * number;
        int sum = 0;

        while (square != 0)
        {
            sum += square % 10;
            square = square / 10;
        }
        return sum == number;
    }

    // c. Method to check Spy Number
    // Spy=>sum of digits == product of digits
    public static bool IsSpy(int number)
    {
        int sum = 0;
        int product = 1;

        while (number != 0)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number = number / 10;
        }
        return sum == product;
    }

    // d. Method to check Automorphic Number
    // Automorphic=> square ends with number
    public static bool IsAutomorphic(int number)
    {
        int square = number * number;
        int temp = number;

        while (temp != 0)
        {
            if (temp % 10 != square % 10)
                return false;

            temp = temp / 10;
            square = square / 10;
        }
        return true;
    }

    // e. Method to check Buzz Number
    // Buzz=>divisible by 7 OR ends with 7
    public static bool IsBuzz(int number)
    {
        return number % 7 == 0 || number % 10 == 7;
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is Prime Number: " + IsPrime(number));
        Console.WriteLine("Is Neon Number: " + IsNeon(number));
        Console.WriteLine("Is Spy Number: " + IsSpy(number));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number: " + IsBuzz(number));
    }
}
