using System;
using System.IO;

class ReadAndCount
{
    public static void Main()
    {
        string filePath="employees.csv";

        try
        {
            int count=0;
            using(StreamReader read=new StreamReader(filePath))
            {
                string line;
                bool header=true;

                while ((line = read.ReadLine()) != null)
                {
                    if (header)
                    {
                        header=false;
                        continue;
                    }
                    string [] data=line.Split(',');
                    for(int i = 0; i < data.Length; i++)
                    {
                        Console.Write(data[i]+" ");
                    }
                    Console.WriteLine("");
                    count++;
                }
            }
            Console.WriteLine("total rows : "+count);
        }
        catch
        {
            Console.WriteLine("An error occured");
        }
    }
}