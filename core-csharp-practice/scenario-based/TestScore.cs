using System;

class TextScore
{
    public static void Main()
    {
        TextScore obj = new TextScore();

        int[] scores = obj.Input();

        int average = obj.AverageMarks(scores);

        obj.HighestMarks(scores);
        obj.LowestMarks(scores);
        obj.DisplayAboveAverage(scores, average);
    }

    // Input scores
    public int[] Input()
    {
        Console.WriteLine("ENTER THE NUMBER OF STUDENTS:");
        int NoOfStudent = Convert.ToInt32(Console.ReadLine());

        int[] scores = new int[NoOfStudent];
        Random r = new Random();

        for (int i = 0; i < NoOfStudent; i++)
        {
            scores[i] = r.Next(0, 101);
        }

        return scores;
    }

    // Average marks
    public int AverageMarks(int[] marks)
    {
        int sum = 0;

        for (int i = 0; i < marks.Length; i++)
        {
            sum += marks[i];
        }

        int average = sum / marks.Length;
        Console.WriteLine("AVERAGE MARKS OF THE STUDENTS IS: " + average);

        return average;
    }

    // Highest marks
    public void HighestMarks(int[] marks)
    {
        int highest = marks[0];

        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] > highest)
            {
                highest = marks[i];
            }
        }
        Console.WriteLine("HIGHEST MARKS OF THE STUDENTS IS: " + highest);
    }

    // Lowest marks
    public void LowestMarks(int[] marks)
    {
        int lowest = marks[0];

        for (int i = 1; i < marks.Length; i++)
        {
            if (marks[i] < lowest)
            {
                lowest = marks[i];
            }
        }
        Console.WriteLine("LOWEST MARKS OF THE STUDENTS IS: " + lowest);
    }

    // Display marks above average
    public void DisplayAboveAverage(int[] marks, int average)
    {
        Console.WriteLine("SCORES ABOVE THE AVERAGE:");

        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > average)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
