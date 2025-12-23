using System;
class AbundantNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the Number");
        int number=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum+=i;
            }
        }
        if (number < sum)
        {
            Console.WriteLine("Number "+number+" is the Abundant number");
        }
        else
        {
            Console.WriteLine("Number "+number +" is not Abundant number");
        }
    }
}