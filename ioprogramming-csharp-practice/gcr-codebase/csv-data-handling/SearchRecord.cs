using System;
using System.IO;

class SearchRecord
{
    public static void Main()
    {
        string filePath = "students.csv";
        try
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = sr.ReadLine()) != null)
                {
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] data = line.Split(',');

                    string id = data[0];
                    string name = data[1];
                    string age = data[2];
                    string marks = data[3];

                    if (name == "Bhanu")
                    {
                        Console.WriteLine("Id : {0}", id);
                        Console.WriteLine("Name : {0}", name);
                        Console.WriteLine("Age : {0}", age);
                        Console.WriteLine("Marks : {0}", marks);
                        break;
                    }
                }
            }
            
        }
        catch(Exception e)
        {
            Console.WriteLine("An error occured : "+e.Message);
        }
    }    
}