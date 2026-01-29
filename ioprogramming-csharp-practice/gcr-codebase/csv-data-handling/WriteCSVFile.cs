using System;
using System.IO;

class WriteCSVFile
{
    public static void Main()
    {
        string filePath="employees.csv";

        try
        {
            using(StreamWriter writer=new StreamWriter(filePath))
            {
                writer.WriteLine("EmployeeID,Name,Salary");
                writer.WriteLine("1,Bhanu,10000");

                // take from user 

                for(int i = 2; i < 6; i++)
                {
                    Console.WriteLine("Enter the Name of Employee"+i);
                    string name=Console.ReadLine();
                    Console.WriteLine("Enter the Salary of Employee"+i);
                    string salary=Console.ReadLine();

                    writer.WriteLine(i+","+name+","+salary+",");
                }
            }
            
        }
        catch (Exception e)
        {
            Console.WriteLine("An error occured : "+e.Message);
        }
    }
}