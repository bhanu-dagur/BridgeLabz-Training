using System;

class NumberChecker6
{
    public static int[] FindFactors(int number)
    {
        int count = 0;

        // First loop to count factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                count++;
        }

        int[] factors = new int[count];
        int index = 0;

        // Second loop to store factors
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
                factors[index++] = i;
        }

        return factors;
    }

    // b. Method to find greatest factor
    public static int GreatestFactor(int[] factors)
    {
        int max = factors[0];
        foreach (int f in factors)
        {
            if (f > max)
                max = f;
        }
        return max;
    }

    // c. Method to find sum of factors
    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
        {
            sum += f;
        }
        return sum;
    }

    // d. Method to find product of factors
    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        foreach (int f in factors)
        {
            product *= f;
        }
        return product;
    }

    // e. Method to find product of cube of factors
    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        foreach (int f in factors)
        {
            product *= Math.Pow(f, 3);
        }
        return product;
    }

    // f. Method to check Perfect Number
    public static bool IsPerfectNumber(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
        {
            if (f != number)
                sum += f;
        }
        return sum == number;
    }

    // g. Method to check Abundant Number
    public static bool IsAbundantNumber(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
        {
            if (f != number)
                sum += f;
        }
        return sum > number;
    }

    // h. Method to check Deficient Number
    public static bool IsDeficientNumber(int number, int[] factors)
    {
        int sum = 0;
        foreach (int f in factors)
        {
            if (f != number)
                sum += f;
        }
        return sum < number;
    }

    // Helper method for factorial
    public static int Factorial(int n)
    {
        int fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }

    // i. Method to check Strong Number
    public static bool IsStrongNumber(int number)
    {
        int temp = number;
        int sum = 0;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += Factorial(digit);
            temp = temp / 10;
        }
        return sum == number;
    }

    // MAIN METHOD
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactors(number);

        Console.Write("Factors: ");
        foreach (int f in factors)
        {
            Console.Write(f + " ");
        }
        Console.WriteLine();

        Console.WriteLine("Greatest Factor: " + GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));

        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number, factors));
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number, factors));
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number, factors));
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }
}
