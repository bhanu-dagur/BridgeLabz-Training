using System;
class PrimeNumber
{
    static void Main()
    {
      Console.WriteLine("Enter the number");
      int n=int.Parse(Console.ReadLine());
      bool ans=IsPrime(n);  
      if(ans)  Console.WriteLine("yes number is the Prime Number");
      else    Console.WriteLine("No number is not a prime number");

    }
    static bool IsPrime(int num)
    {
        if(num<1 )  return false;
        for(int i = 2; i <= num / 2; i++)
        {
            if (num % i== 0)
            {
                return false;
            }
            
        }
        return true;
    }
}