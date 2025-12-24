using System;
class StoreMultiVaues
{
    static void Main()
    {
        double []arr=new double[10];
        double total=120.0;
        Console.WriteLine("Enter the Multiple Values ");

        int idx=0;
        while (true)
        {
            int value=int.Parse(Console.ReadLine());

            if (value <=0)
            {
                break;
            }
            if (idx == 10)
            {
                break;
            }
            arr[idx]=value;
            idx++;
        }
        for(int i = 0; i < arr.Length; i++)
        {
            total+=arr[i];
        }
        Console.WriteLine("total value in the array: "+total);
    }
}