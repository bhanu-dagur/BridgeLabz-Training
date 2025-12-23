using System;
using System.IO.Pipes;
class SmallestOfThreeNumber
{
    static void Main(string[] args)
    {
        int firstNumber=Convert.ToInt32(Console.ReadLine());
        int secondNumber=Convert.ToInt32(Console.ReadLine());
        int thirdNumber=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Is the first number the smallest? ");
        if((firstNumber<secondNumber) && (firstNumber < thirdNumber))
        {
            Console.WriteLine(" yes");
        }
        else
        {
            Console.WriteLine("No ");
        }
    }
}
    