using System;
class UserFeeDisount
{
    public static void Main(String[] args)
    {
        double fee=Convert.ToDouble(Console.ReadLine());
        double discountPercent=Convert.ToDouble(Console.ReadLine());
        double discount=(fee*discountPercent)/100;
        Console.WriteLine("The discount amount is "+discount+" and final remainning fees is"+(fee-discount));
    }
}