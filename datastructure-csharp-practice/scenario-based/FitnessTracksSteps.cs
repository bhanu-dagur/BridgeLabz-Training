using System;
class FitnessTracksSteps
{
    static void Main()
    {
       SortTracksSteps obj=new SortTracksSteps();
       Console.WriteLine("Enter the number of people:");
       int size=Convert.ToInt32(Console.ReadLine());
       int [] arr=new int[size];

       Random random=new Random();

       for(int i=0;i<size;i++)
        {
            arr[i]=random.Next(0,100);
        }

        obj.BubbleSort(arr);

        for(int i=0;i<size;i++)
        {
            Console.WriteLine(arr[i]);
        } 
    }
}
class SortTracksSteps
{
    public void BubbleSort(int [] arr)
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
}