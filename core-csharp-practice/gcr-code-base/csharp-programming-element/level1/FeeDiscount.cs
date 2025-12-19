using System;
class FeeDistcount
{
    static void Main(String[] args)
    {
        int fees=125000;
        int discountPercent=10;
        int discount=(fees*discountPercent)/100;
        int remainingFee=fees-discount;
        Console.WriteLine("The discount amount is "+discount+"and the remaining fees is "+ remainingFee);
    }
}