using System;
class SalaryBonus
{
    static void Main()
    {
        Console.WriteLine("enter your salary");
        int salary=int.Parse(Console.ReadLine());
        Console.WriteLine(" Enter your year of completion");
        int year =int.Parse(Console.ReadLine());

        if (year > 5)
        {
            int bonus=(salary*5)/100;
            Console.WriteLine(" Your bonus will be : "+ bonus);
        }
        else
        {
            Console.WriteLine("Your year of completion is less than five, thank you");
        }


    }
}