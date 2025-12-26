using System;

class BonusOfEmployee
{
    public static double[,] GenerateEmployeeData()
    {
        double[,] data = new double[10, 2]; // salary, years 
        Random rnd = new Random();

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rnd.Next(10000, 99999);
            data[i, 1] = rnd.Next(1, 11);        
        }
        return data;
    }
    public static double[,] CalculateBonus(double[,] oldData)
    {
        double[,] newData = new double[10, 2]; // new salary, bonus

        for (int i = 0; i < 10; i++)
        {
            double salary = oldData[i, 0];
            double years = oldData[i, 1];
            double bonus;

            if (years > 5)
                bonus = salary * 0.05;
            else
                bonus = salary * 0.02;

            newData[i, 0] = salary + bonus;
            newData[i, 1] = bonus;
        }
        return newData;
    }

    public static void DisplayReport(double[,] oldData, double[,] newData)
    {
        double totalOld = 0, totalNew = 0, totalBonus = 0;

        Console.WriteLine("Emp\tOldSalary\tYears\tBonus\tNewSalary");

        for (int i = 0; i < 10; i++)
        {
            totalOld += oldData[i, 0];
            totalNew += newData[i, 0];
            totalBonus += newData[i, 1];

            Console.WriteLine((i + 1) + "\t" +oldData[i, 0] + "\t" + oldData[i, 1] + "\t" +
                newData[i, 1] + "\t" +
                newData[i, 0]
            );
        }

        Console.WriteLine("\nTotal Old Salary = " + totalOld);
        Console.WriteLine("Total Bonus Paid = " + totalBonus);
        Console.WriteLine("Total New Salary = " + totalNew);
    }

    static void Main()
    {
        double[,] oldData = GenerateEmployeeData();
        double[,] newData = CalculateBonus(oldData);
        DisplayReport(oldData, newData);
    }
}
