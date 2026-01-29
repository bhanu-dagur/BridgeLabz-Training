using System;
using System.IO;

class FilterRecord
{
    public static void Main()
    {
        string filePath="students.csv";
        try
        {
            using(StreamReader reader=new StreamReader(filePath))
            {
                string line;
                bool header=true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (header)
                    {
                        string[] head=line.Split(',');
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine(
                            " | "+head[0]+
                            " | "+head[1]+
                            " | "+head[2]+
                            " | "+head[3]+" | "
                        );
                        Console.WriteLine("--------------------------------------------------");
                        header=false;
                        continue;
                    }

                    string [] data=line.Split(',');
                    int marks=int.Parse(data[3]);

                    if (marks > 80)
                    {
                        Console.WriteLine(
                            " | "+data[0]+
                            " | "+data[1]+
                            " | "+data[2]+
                            " | "+data[3]+" | "
                        );
                    }
                    
                }
            }
            Console.WriteLine("-----------------------------------------");
            

        }
        catch(Exception e)
        {
            Console.WriteLine("Error Occured : "+e.Message);
        }
    }
}