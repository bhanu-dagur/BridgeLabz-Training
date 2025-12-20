using System;
class TempConversion
{
    public static void Main(String []args){
        double celsius,fahrenheit;
        fahrenheit=Convert.ToDouble(Console.ReadLine());
        celsius=(5.0/9.0)*(fahrenheit-32);
        Console.WriteLine("The "+ fahrenheit+" fahrenheit"+ "is "+ celsius+" celsius");
    }
}