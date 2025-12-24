using System;

class FirstTwoLargestNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the Number:");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 10;
        int[] arr = new int[maxDigit];
        int idx = 0;

        // Store digits in array
        while (number != 0 && idx < maxDigit)
        {
            int digit = number % 10;
            arr[idx++] = digit;
            number = number / 10;
        }

        int largest = 0;
        int secondLargest = 0;

        // Find largest and second largest
        for (int i = 0; i < idx; i++)
        {
            if (arr[i] > largest)
            {
                secondLargest = largest;
                largest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != largest)
            {
                secondLargest = arr[i];
            }
        }

        Console.WriteLine("Largest element: " + largest);
        Console.WriteLine("Second largest element: " + secondLargest);
    }
}
