using System;
using System.Diagnostics;
using System.Text;

class CampareStringConcatenation
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int n in sizes)
        {
            Console.WriteLine("\nOperations Count: " + n);

            // Using string
            Stopwatch sw1 = Stopwatch.StartNew();
            string s = "";

            for (int i = 0; i < n; i++)
            {
                s += "a";
            }

            sw1.Stop();
            Console.WriteLine("string time: " + sw1.ElapsedMilliseconds + " ms");

            //  Using StringBuilder 
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append("a");
            }

            sw2.Stop();
            Console.WriteLine("StringBuilder time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}
