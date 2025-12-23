using System;
class FactorialUsingWhile
{
    static void Main()
    {
        Console.WriteLine("Enter the Natural Number");
        int number=int.Parse(Console.ReadLine());


        if (number > 0)
        {

            for(int i=1;i<number;i++)
            {
                if(i%2==0 ){
                    Console.WriteLine("Number "+i+" is the even number");
                }
                else
                {
                    Console.WriteLine("Nummber " +i+ " is a odd number ");
                }
            }
           
        }
        else
        {
            Console.WriteLine("Please enter the natural number");
        }
    }
}