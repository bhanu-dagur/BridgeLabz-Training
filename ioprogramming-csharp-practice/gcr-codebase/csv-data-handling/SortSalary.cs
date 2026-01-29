using System;
using System.IO;
using System.Collections.Generic;

class Employee
{
    public string Id;
    public string Name;
    public string Department;
    public double Salary;
}

class SortCSV_WithoutLINQ
{
    static void Main()
    {
        string filePath = "employees.csv";
        List<Employee> list = new List<Employee>();
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            bool header = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (header) { header = false; continue; }

                string[] d = line.Split(',');

                list.Add(new Employee
                {
                    Id = d[0],
                    Name = d[1],
                    Department = d[3],
                    Salary = double.Parse(d[2])
                });
            }
        }

        //  Sort by Salary Descending
        list.Sort((a, b) => b.Salary.CompareTo(a.Salary));

        Console.WriteLine("Top 5 Highest Paid Employees\n");

        for (int i = 0; i < 5 && i < list.Count; i++)
        {
            Console.WriteLine(
                list[i].Name + " | " +
                list[i].Department + " | " +
                list[i].Salary
            );
        }
            
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occured : "+e.Message);
        }
    }
}
