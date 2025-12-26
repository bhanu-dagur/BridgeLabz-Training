using System;
class Armstrome
{
    public static void Main()
    {
        Console.WriteLine("enter the number");
        int number=Convert.ToInt32(Console.ReadLine());

        int temp=number;
        int sum=0;
        while (temp > 0)
        {
            int digit=temp%10;
            sum+=digit*digit*digit;
            temp=temp/10;

        }
        if (sum==number)
        {
            Console.WriteLine("Yes number is the Armstrome");
        }
        else
        {
            Console.WriteLine("Number is not ArmStrome");
        }
    }
}