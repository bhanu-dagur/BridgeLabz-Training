using System;
using System.Diagnostics;

class CompareSorting
{
    static void Main()
    {
        int[] sizes = { 1000, 10000 }; 

        foreach (int size in sizes)
        {
            Console.WriteLine("\nDataset Size: " + size);

            int[] original = GenerateArray(size);

            // Bubble Sort
            int[] bubbleArr = (int[])original.Clone();
            Stopwatch sw1 = Stopwatch.StartNew();
            BubbleSort(bubbleArr);
            sw1.Stop();
            Console.WriteLine("Bubble Sort Time: " + sw1.ElapsedMilliseconds + " ms");

            // Merge Sort
            int[] mergeArr = (int[])original.Clone();
            Stopwatch sw2 = Stopwatch.StartNew();
            MergeSort(mergeArr, 0, mergeArr.Length - 1);
            sw2.Stop();
            Console.WriteLine("Merge Sort Time: " + sw2.ElapsedMilliseconds + " ms");

            // Quick Sort
            int[] quickArr = (int[])original.Clone();
            Stopwatch sw3 = Stopwatch.StartNew();
            QuickSort(quickArr, 0, quickArr.Length - 1);
            sw3.Stop();
            Console.WriteLine("Quick Sort Time: " + sw3.ElapsedMilliseconds + " ms");
        }

        // Large Dataset (1,000,000) 
        Console.WriteLine("\nDataset Size: 1,000,000 (Bubble Sort skipped)");

        int[] largeArray = GenerateArray(1000000);

        Stopwatch sw4 = Stopwatch.StartNew();
        MergeSort(largeArray, 0, largeArray.Length - 1);
        sw4.Stop();
        Console.WriteLine("Merge Sort Time: " + sw4.ElapsedMilliseconds + " ms");

        largeArray = GenerateArray(1000000);
        Stopwatch sw5 = Stopwatch.StartNew();
        QuickSort(largeArray, 0, largeArray.Length - 1);
        sw5.Stop();
        Console.WriteLine("Quick Sort Time: " + sw5.ElapsedMilliseconds + " ms");
    }

    // Bubble Sort 
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort 
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
                arr[k++] = L[i++];
            else
                arr[k++] = R[j++];
        }

        while (i < n1) arr[k++] = L[i++];
        while (j < n2) arr[k++] = R[j++];
    }

    //  Quick Sort 
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    //  Dataset Generator 
    static int[] GenerateArray(int size)
    {
        int[] arr = new int[size];
        Random rand = new Random();

        for (int i = 0; i < size; i++)
        {
            arr[i] = rand.Next(size);
        }

        return arr;
    }
}
