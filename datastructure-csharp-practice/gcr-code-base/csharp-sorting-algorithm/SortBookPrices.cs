using System;
class SortBookPrices
{
    public static void MergeSort(int [] prices,int left,int right)
    {
        if (left <right)
        {
            int mid=left+(right-left)/2;
            MergeSort(prices,left,mid);
            MergeSort(prices,mid+1,right);
            Merge(prices,left,mid,right); 
        }

    }
    public static void Merge(int[] prices,int left,int mid,int right)
    {
        int n1=mid-left+1,n2=right-mid;
        int [] leftArr=new int[n1],rightArr=new int[n2];

        for(int i=0;i<n1;i++) leftArr[i]=prices[left+i];
        for(int i=0;i<n2;i++) rightArr[i]=prices[mid+1+i];

        int index=left;
        int leftIndex=0,rightIndex=0;
  
        while(leftIndex<n1 && rightIndex < n2)
        {
            if (leftArr[leftIndex] <= rightArr[rightIndex])
            {
                prices[index++]=leftArr[leftIndex++];

            }
            else
            {
                prices[index++]=rightArr[rightIndex++];
            }
        }

        while(leftIndex<n1)  prices[index++]=leftArr[leftIndex++];
        while(rightIndex<n2) prices[index++]=rightArr[rightIndex++];

    }

    public static void Main()
    {
        int [] arr={ 12, 11, 13, 5, 6, 7 };
        Console.WriteLine("Array before sorting:");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        MergeSort(arr,0,arr.Length-1);
        Console.WriteLine("\nArray after sorting:");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}