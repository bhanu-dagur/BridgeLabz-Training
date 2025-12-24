using System;

class BonusOfEmployee
{
    static void Main()
    {
        double[,] employee = new double[10, 2]; // [salary, years]
        double totalNewSalary = 0, totalOldSalary = 0, totalBonus = 0;

       
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter salary of employee:"+(i + 1));
            employee[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter years of service of employee :"+(i + 1));
            employee[i, 1] = Convert.ToDouble(Console.ReadLine());

            if (employee[i, 0] <= 0 || employee[i, 1] < 0)
            {
                Console.WriteLine("Invalid input! Enter again.");
                i--;
                continue;
            }

            totalOldSalary += employee[i, 0];
        }

        double[] newSalary = new double[10];
        double[] bonus = new double[10];

        for (int i = 0; i < 10; i++)
        {
            if (employee[i, 1] > 5)
            {
                bonus[i] = employee[i, 0] * 0.05;
            }
            else
            {
                bonus[i] = employee[i, 0] * 0.02;
            }

            newSalary[i] = employee[i, 0] + bonus[i];

            totalBonus += bonus[i];
            totalNewSalary += newSalary[i];
        }

        
        Console.WriteLine("Total Old Salary : "+totalOldSalary);
        Console.WriteLine("Total Bonus Paid : "+totalBonus);
        Console.WriteLine("Total New Salary : "+totalNewSalary);
    }
}
