using System;

class ArmStrongNumber
{
    static void Main()
    {
        int number, originalNumber;
        int sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        originalNumber = number;

        
        while (originalNumber != 0)
        {
            int rem = originalNumber % 10;

            sum = sum + (rem * rem * rem);

            originalNumber = originalNumber / 10;
        }

        // Check Armstrong condition
        if (sum == number)
        {
            Console.WriteLine(number + " is an Armstrong Number");
        }
        else
        {
            Console.WriteLine(number + " is not an Armstrong Number");
        }
    }
}
