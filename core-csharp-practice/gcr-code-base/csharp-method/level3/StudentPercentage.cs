using System;

class StudentPercentage
{
    public static double[,] GenerateMarks(int n)
    {
        double[,] marks = new double[n, 3];
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            marks[i, 0] = rnd.Next(10, 100); 
            marks[i, 1] = rnd.Next(10, 100); 
            marks[i, 2] = rnd.Next(10, 100); 
        }
        return marks;
    }

    public static double[,] CalculateResults(double[,] marks)
    {
        int n = marks.GetLength(0);
        double[,] result = new double[n, 3];

        for (int i = 0; i < n; i++)
        {
            double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            result[i, 0] = Math.Round(total, 2);
            result[i, 1] = Math.Round(average, 2);
            result[i, 2] = Math.Round(percentage, 2);
        }
        return result;
    }
    public static void DisplayScoreCard(double[,] marks, double[,] result)
    {
        Console.WriteLine("Stu\tPhy\tChem\tMath\tTotal\tAvg\t%");

        for (int i = 0; i < marks.GetLength(0); i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                marks[i, 0] + "\t" +
                marks[i, 1] + "\t" +
                marks[i, 2] + "\t" +
                result[i, 0] + "\t" +
                result[i, 1] + "\t" +
                result[i, 2]
            );
        }
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = int.Parse(Console.ReadLine());

        double[,] marks = GenerateMarks(n);
        double[,] result = CalculateResults(marks);
        DisplayScoreCard(marks, result);
    }
}
