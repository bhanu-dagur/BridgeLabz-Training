using System;
using System.Diagnostics;

class SearchTarget
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };
        int target = -1;   // target at the end (worst case)

        foreach (int size in sizes)
        {
            Console.WriteLine("\nDataset Size: " + size);

            // Create dataset
            int[] data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = i;
            }

            // -------- Linear Search --------
            Stopwatch sw1 = Stopwatch.StartNew();
            LinearSearch(data, target);
            sw1.Stop();

            Console.WriteLine("Linear Search Time: " + sw1.ElapsedMilliseconds + " ms");

            // -------- Binary Search --------
            Stopwatch sw2 = Stopwatch.StartNew();
            BinarySearch(data, target);
            sw2.Stop();

            Console.WriteLine("Binary Search Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }

    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return -1;
    }
}
