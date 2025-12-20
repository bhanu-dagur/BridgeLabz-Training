using System;
class TempConversion
{
    public static void Main(String []args){
        double celsius,fahrenheit;
        celsius=Convert.ToDouble(Console.ReadLine());
        fahrenheit=celsius*(9.0/5.0)+32;
        Console.WriteLine("The "+ celsius+" celsius"+ "is "+ fahrenheit+" fahrenheit");
    }
}