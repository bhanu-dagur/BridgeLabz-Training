using System;

class FirstLargestCopyArray
{
    static void Main()
    {
        Console.WriteLine("Enter the Number:");
        String number = Console.ReadLine();

        int maxDigit = 10;
        int[] arr = new int[maxDigit];
        int idx = 0;

        // Store digits in array
        for(int i=0;i<number.Length;i++)
        {
            if (maxDigit == idx)
            {
                int []temp=new int[maxDigit+10];
                for(int j = 0; j < arr.Length; j++)
                {
                    temp[j]=arr[j];
                }
                arr=temp;
            }
            arr[idx++] = number[i];
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
