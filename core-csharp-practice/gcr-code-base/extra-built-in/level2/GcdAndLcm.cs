using System;
class GcdAndLcm
{
    static void Main()
    {
        Console.WriteLine("Enter the first number");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number");
        int num2=int.Parse(Console.ReadLine());

        int gcd=Gcd(num1,num2);
        int lcm=Lcm(num1,num2);

        Console.WriteLine("GCD of the number is : "+gcd);
        Console.WriteLine("LCM of the number is : "+lcm);

    }
    static int Gcd(int x,int y)
    {
        
        while (y != 0)
        {
           int rem=x % y;
           x=y;
           y=rem; 
        }
        return x;
    }
    static int Lcm(int x,int y)
    {
        int max=Math.Max(x,y);
        while (true)
        {
            if(max%x==0 && max % y==0)
            {
                return max;
            }
            max++;
        }
    }
}