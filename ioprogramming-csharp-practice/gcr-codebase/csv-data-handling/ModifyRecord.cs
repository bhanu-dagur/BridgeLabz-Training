using System;
using System.IO;
using System.Collections.Generic;

// record updated into new file
// class ModifyRecord
// {
//     public static void Main()
//     {
//         string filePath="employees.csv";
//         string updatedSalary="updatedSalary.csv";
//         try
//         {
//             using(StreamReader reader=new StreamReader(filePath))
//             using(StreamWriter writer=new StreamWriter(updatedSalary))
//             {
//                 string line;
//                 bool header=true;
//                 while ((line = reader.ReadLine()) != null)
//                 {
//                     if (header)
//                     {
//                         header=false;
//                         continue;
//                     }
//                     string [] data=line.Split(',');
//                     if (data[3].Equals("IT", StringComparison.OrdinalIgnoreCase))
//                     {
//                         double salary=Convert.ToDouble(data[2]);
//                         double newSalary=salary+(salary*0.10);
//                         data[2]=newSalary.ToString();
//                     }
//                     writer.WriteLine(data[0]+","+data[1]+","+data[2]+","+data[3]);
//                 }
//             }
//             Console.WriteLine("Record updated successfully");
//         }
//         catch(Exception e)
//         {
//             Console.WriteLine("An error occured : "+e.Message);
//         }
//     }
// }

// record updated into same file “Because a file cannot be read and written at the same time safely.
// Therefore, we read data first, update it in memory, and then overwrite the file.”

class ModifyRecord
{
    public static void Main()
    {
        string filePath="employees.csv";
        List<string> updatedLines=new List<string>();
        try
        {
            using(StreamReader reader=new StreamReader(filePath))
            {
                string line;
                bool header=true;

                while((line = reader.ReadLine()) != null)
                {
                    if (header)
                    {
                        header=false;
                        continue;
                    }
                    string [] data=line.Split(',');
                    if(data[3].Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        double salary=double.Parse(data[2]);
                        double newSalary=salary+(salary*0.10);
                        data[2]=newSalary.ToString();
                        
                    }
                    updatedLines.Add(data[0]+","+data[1]+","+data[2]+","+data[3]);
                }

                
                
            }

            using(StreamWriter writer=new StreamWriter(filePath,false))
            new StreamWriter(filePath, false);
            // false means file will be overwritten , first clean all file data and then write
            // true means file will be appended
            
            {
                foreach(string line in updatedLines)
                {
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Record updated successfully");
        }
        catch(Exception e)
        {
            Console.WriteLine("An error occured : "+e.Message);
        }
    }
}