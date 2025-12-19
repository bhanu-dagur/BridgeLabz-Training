using System;
using System.Runtime.CompilerServices;
class ProfitLossPercent
{
    public static void Main(String[] args)
    {
        double costPrice=129.0;
        double sellingPrice=191;
        double profit=sellingPrice-costPrice;
        double profitPercent=(double)(profit*100)/costPrice;
        Console.WriteLine("The Cost Price is INR 129 and Selling Price is INR 191"+ "");
        Console.WriteLine("The Profit is INR "+ profit+" and the profit percentage is "+ profitPercent);
    } 
}