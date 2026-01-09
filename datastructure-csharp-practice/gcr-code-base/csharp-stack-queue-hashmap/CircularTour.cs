using System;

class CircularTour
{
    public static int FindStartingPoint(int[] petrol, int[] distance)
    {
        int balance = 0;
        int deficit = 0;
        int start = 0;

        for (int i = 0; i < petrol.Length; i++)
        {
            balance += petrol[i] - distance[i];

            if (balance < 0)
            {
                deficit += balance;
                start = i + 1;
                balance = 0;
            }
        }

        if (balance + deficit >= 0)
            return start;
        else
            return -1;
    }

    static void Main()
    {
        int[] petrol = { 4, 6, 7, 4 };
        int[] distance = { 6, 5, 3, 5 };

        int start = FindStartingPoint(petrol, distance);

        if (start == -1)
            Console.WriteLine("Tour not possible");
        else
            Console.WriteLine("Start from petrol pump: " + start);
    }
}
