using System;
class Factorial
{
    static void Main()
    {
        int number=Input();
        int result=Fact(number);
        DisplayResult(result,number);
    }
    static int Input()
    {
        Console.WriteLine("Enter the Number");
        int num=Convert.ToInt32(Console.ReadLine());
        return num ;
    }
    static int Fact(int n)
    {
        if(n==0 || n == 1)
        {
            return 1;
        }

        int ans=n*Fact(n-1);
        return ans;
    }
    static void DisplayResult(int result,int num)
    {
        Console.WriteLine("Factorial of the "+ num+ " is : "+result);
    }
}