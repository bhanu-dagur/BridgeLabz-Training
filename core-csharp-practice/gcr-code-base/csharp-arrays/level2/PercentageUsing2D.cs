using System;

class PercentageUsing2D
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        int[,] marks = new int[n, 3];   // Physics, Chemistry, Maths
        double[] percentage = new double[n];
        char[] grade = new char[n];

        // Input marks
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter marks for Student " + (i + 1));
            
            Console.WriteLine("Enter the marks of subjects");
            for (int j = 0; j < 3; j++)
            {
                // string subject = (j == 0) ? "Physics" : (j == 1) ? "Chemistry" : "Maths";
                // Console.Write("Enter marks for " + subject + ": ");
                
                int value = int.Parse(Console.ReadLine());

                if (value < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Enter again.");
                    j--; 
                }
                else
                {
                    marks[i, j] = value;
                }
            }
        }

        // Calculate percentage and grade
        for (int i = 0; i < n; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
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
            Console.WriteLine("Physics: " + marks[i, 0]);
            Console.WriteLine("Chemistry: " + marks[i, 1]);
            Console.WriteLine("Maths: " + marks[i, 2]);
            Console.WriteLine("Percentage: " + percentage[i] + "%");
            Console.WriteLine("Grade: " + grade[i]);
        }
    }
}
