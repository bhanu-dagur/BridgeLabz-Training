using System;
using System.Data;
class CheckStudentVote
{
    static void Main()
    {
        int [] number=new int[5];
        Console.WriteLine("Enter five numbers");
        for(int i = 0; i <  5; i++)
        {
            number[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i = 0; i < number.Length; i++)
        {
            int num=number[i];
            if (num > 0)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Number is Positive Even number");
                }
                else
                {
                    Console.WriteLine("Number is Positive Odd number");
                }
            }
            else if (num == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else
            {
                Console.WriteLine("Number is Negative");
            }

        }
        if (number[0] == number[number.Length])
        {
            Console.WriteLine("First and last element of the array are equal");
        }
        else if (number[0] > number[4])
        {
            Console.WriteLine("First element is greater than the Last element of the Array");
        }
        else
        {
            Console.WriteLine("First element is the less than last element in the array");
        }

    }
}