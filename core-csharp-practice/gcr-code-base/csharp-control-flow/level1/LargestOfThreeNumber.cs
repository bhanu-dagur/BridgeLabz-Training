using System;
using System.IO.Pipes;
class SmallestOfThreeNumber
{
    static void Main(string[] args)
    {
        int firstNumber=Convert.ToInt32(Console.ReadLine());
        int secondNumber=Convert.ToInt32(Console.ReadLine());
        int thirdNumber=Convert.ToInt32(Console.ReadLine());

        bool FirstLargest = firstNumber >secondNumber && firstNumber > thirdNumber;
        bool SecondLargest =secondNumber > firstNumber &&secondNumber > thirdNumber;
        bool ThirdLargest = thirdNumber > firstNumber && thirdNumber >secondNumber;

        Console.WriteLine("Is the first number the largest? " + FirstLargest);
        Console.WriteLine("Is the second number the largest? " + SecondLargest);
        Console.WriteLine("Is the third number the largest? " + ThirdLargest);
    }
}
    