using System;
class SumOfNaturalUsingWhile
{
    static void Main()
    {
        int totalUsingFormula, totalUsingWhile=0;
        Console.WriteLine("enter a natural number");
        int number=int.Parse(Console.ReadLine());
        if (number < 1)
        {
            Console.WriteLine("it is not natural number ple enter natural number ");
        }
        else
        {
            
              //using formula            
            totalUsingFormula=number*(number+1)/2;
            for(int i=1;i<=number;i++)
            {
                totalUsingWhile+=i;
                
                
            }
           
            
            if (totalUsingFormula == totalUsingWhile)
            {
                Console.WriteLine("Both are equal and Sum is "+ totalUsingFormula);
            }
            else
            {
                Console.WriteLine("Both are not equal");
            }
        }
    }
}