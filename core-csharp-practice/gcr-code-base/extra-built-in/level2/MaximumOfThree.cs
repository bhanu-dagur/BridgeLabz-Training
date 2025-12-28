using System;
class MaximumOfThree
{
    static void Main()
    {
       Console.WriteLine("Enter the three numbers");
       int a=Input();
       int b=Input();
       int c=Input();
       int max=FindMaximum(a,b,c);
       Console.WriteLine("Maximum number from three numbers is: "+max); 
    }
    static int Input()
    {
       return Convert.ToInt32(Console.ReadLine()); 
    }
    static int FindMaximum(int a,int b,int c)
    {
        if(a>b && a > c)
        {
            return a;
        }
        else if(b>a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}