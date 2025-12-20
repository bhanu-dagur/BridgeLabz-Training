using System;

class FindTotalIncome
{
    static void Main()
    {
        int salary, bonus, income;

        Console.Write("Enter salary: ");
        salary = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter bonus: ");
        bonus = Convert.ToInt32(Console.ReadLine());

        income = salary + bonus;

        Console.WriteLine("The salary is INR " + salary +" and bonus is INR " + bonus +". Hence Total Income is INR " + income );
    }
}
