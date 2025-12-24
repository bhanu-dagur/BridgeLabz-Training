using System;

class PercentageUsing1D
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[] physics = new int[n];
        int[] chemistry = new int[n];
        int[] maths = new int[n];
        double[] percentage = new double[n];
        char[] grade = new char[n];

        // Input marks
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nEnter marks for Student " + (i + 1));

            Console.Write("Physics: ");
            physics[i] = int.Parse(Console.ReadLine());
            if (physics[i] < 0) { Console.WriteLine("Invalid marks"); i--; continue; }

            Console.Write("Chemistry: ");
            chemistry[i] = int.Parse(Console.ReadLine());
            if (chemistry[i] < 0) { Console.WriteLine("Invalid marks"); i--; continue; }

            Console.Write("Maths: ");
            maths[i] = int.Parse(Console.ReadLine());
            if (maths[i] < 0) { Console.WriteLine("Invalid marks"); i--; continue; }
        }

        // Calculate percentage & grade
        for (int i = 0; i < n; i++)
        {
            int total = physics[i] + chemistry[i] + maths[i];
            percentage[i] = total / 3.0;

            if (percentage[i] >= 80)
                grade[i] = 'A';
            else if (percentage[i] >= 70)
                grade[i] = 'B';
            else if (percentage[i] >= 60)
                grade[i] = 'C';
            else if (percentage[i] >= 50)
                grade[i] = 'D';
            else if (percentage[i] >= 40)
                grade[i] = 'E';
            else
                grade[i] = 'R';
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nStudent " + (i + 1));
            Console.WriteLine("Physics: " + physics[i]);
            Console.WriteLine("Chemistry: " + chemistry[i]);
            Console.WriteLine("Maths: " + maths[i]);
            Console.WriteLine("Percentage: " + percentage[i] + "%");
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
