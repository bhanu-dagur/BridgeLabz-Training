using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
class FlashDealz
{
    static void Main()
    {
        Random random=new Random();
        int []arr=new int[100];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i]=random.Next(0,100);
        }
        
        SortDiscount sd=new SortDiscount();
        sd.QuickSort(arr,0,arr.Length-1);
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
class SortDiscount
{
    public void QuickSort(int [] arr,int low,int high)
    {
        if (low < high)
        {
            int pivot=Partition(arr,low,high);
            QuickSort(arr,low,pivot-1);
            QuickSort(arr,pivot+1,high);
        }
    }
    public int Partition(int [] arr,int low,int high)
    {
        int pivot=arr[high];
        int i=low-1;
        for(int j = low;j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp1=arr[i];
                arr[i]=arr[j];
                arr[j]=temp1;
            }
        }
        int temp=arr[i+1];
        arr[i+1]=arr[high];
        arr[high]=temp;
        return i+1;
    }
}