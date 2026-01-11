using System;
class SortEmployeeId
{
    public static void Sort(int [] ids)
    {
        // Arrya divided int two part right part and left which is already sorted;
        for(int right = 1; right < ids.Length; right++)
        {
            int key=ids[right];
            int left=right-1;

            // Shift element untill the correct position is found;
            while(left>=0 && ids[left] > key)
            {
                ids[left+1]=ids[left];
                left--;
            }
            ids[left+1]=key;
        }
    }
    public static void Main(string[] args)
    {
        int [] arr={1,2,-3,4,-5,8,3,2};
        Console.WriteLine("Array before sorting: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Sort(arr);
        Console.WriteLine("\nArray after sorting: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        
    }
}