using System;

class HarshadNumber
{
    static void Main()
    {
        int number, originalNumber;
        int sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        originalNumber = number;
        
        while (number != 0)
        {
            int digit = number % 10;  
            sum = sum + digit;         
            number = number / 10;      
        }
        // Check Harshad condition
        if (originalNumber % sum == 0)
        {
            Console.WriteLine("Harshad Number");
        }
        else
        {
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
