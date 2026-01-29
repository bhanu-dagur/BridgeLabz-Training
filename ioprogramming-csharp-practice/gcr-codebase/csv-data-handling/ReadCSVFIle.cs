using System;
using System.IO;

class ReadCSVFile
{
    static void Main()
    {
        string filePath = "students.csv";

        try
        {
            // File open karo read mode me
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                bool isHeader = true;

                while ((line = sr.ReadLine()) != null)
                {
                    // Header line skip karo
                    if (isHeader)
                    {
                        isHeader = false;
                        continue;
                    }

                    // Comma se data split karo
                    string[] data = line.Split(',');

                    string id = data[0];
                    string name = data[1];
                    string age = data[2];
                    string marks = data[3];

                    // Structured output
                    Console.WriteLine("Student ID : " + id);
                    Console.WriteLine("Name       : " + name);
                    Console.WriteLine("Age        : " + age);
                    Console.WriteLine("Marks      : " + marks);
                    Console.WriteLine("---------------------------");
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check file path.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(" Error: " + ex.Message);
        }
    }
}
