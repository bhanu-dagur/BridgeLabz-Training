using System;

class BubbleSortStudentMarks
{
    static void BubbleSort(int[] marks)
    {
        int n = marks.Length;

        // Outer loop for passes
        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            // Inner loop for comparison
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (marks[j] > marks[j + 1])
                {
                    // Swap
                    int temp = marks[j];
                    marks[j] = marks[j + 1];
                    marks[j + 1] = temp;

                    swapped = true;
                }
            }

            // If no swap happened, array already sorted
            if (!swapped)
                break;
        }
    }

    static void Main()
    {
        int[] studentMarks = { 78, 45, 89, 32, 67, 90 };

        Console.WriteLine("Before Sorting:");
        foreach (int m in studentMarks)
            Console.Write(m + " ");

        BubbleSort(studentMarks);

        Console.WriteLine("\nAfter Sorting (Ascending):");
        foreach (int m in studentMarks)
            Console.Write(m + " ");
    }
}
