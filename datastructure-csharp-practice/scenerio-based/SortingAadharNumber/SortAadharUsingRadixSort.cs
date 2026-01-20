using System;

class SortAadharUsingRadixSort
{
    public static void Main()
    {
        SortAadharUsingRadixSort obj = new SortAadharUsingRadixSort();

        Console.WriteLine("Enter the number of Aadhar cards to be sorted:");
        int noOfAadhar = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();

        long[] aadhars = new long[noOfAadhar];

        // Generate random 12-digit Aadhar-like numbers
        for (int i = 0; i < aadhars.Length; i++)
        {
            long firstPart=rand.Next(100000,900000);
            long secondPart = rand.Next(100000, 900000);
            aadhars[i] = firstPart*1000000 + secondPart;
        }

        Console.WriteLine("\nBefore Sorting:");
        PrintArray(aadhars);

        obj.RadixSort(aadhars);

        Console.WriteLine("\nAfter Sorting:");
        PrintArray(aadhars);
    }

    //  RADIX SORT
    public void RadixSort(long[] arr)
    {
        long max = GetMax(arr);

        for (long exp = 1; max / exp > 0; exp *= 10)
        {
            CountSort(arr, exp);
        }
    }

    // COUNTING SORT  
    public void CountSort(long[] arr, long exp)
    {
        int n = arr.Length;

        long[] output = new long[n];
        int[] freq = new int[10]; // digits 0–9

        //  Count frequency of digits
        for (int i = 0; i < n; i++)
        {
            int digit = (int)((arr[i] / exp) % 10);
            freq[digit]++;
        }

        //  Prefix sum (cumulative count)  it give the correct last position in the sorted array
        for (int i = 1; i < 10; i++)
        {
            freq[i] += freq[i - 1];
        }

        // 3 Build output array (RIGHT TO LEFT → stability)
        for (int i = n - 1; i >= 0; i--)
        {
            int digit = (int)((arr[i] / exp) % 10);
            output[freq[digit] - 1] = arr[i];
            freq[digit]--;
        }

        for (int i = 0; i < n; i++)
        {
            arr[i] = output[i];
        }
    }

    public long GetMax(long[] arr)
    {
        long max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    //  PRINT ARRAY 
    static void PrintArray(long[] arr)
    {
        foreach (long num in arr)
        {
            Console.WriteLine(num);
        }
    }
}
