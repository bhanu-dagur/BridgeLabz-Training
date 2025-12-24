using System;

class ReverseNumber
{
    static void Main()
    {
        Console.WriteLine("Enter the number");
        int number=Convert.ToInt32(Console.ReadLine());
        int count=0;
        int temp=number;

        // digit count in an array
        while (temp!=0)
        {
            int digit=temp%10;
            temp=temp/10;
            count++;
        }
        int [] arr=new int[count];
        int index=0;

        while (number != 0)
        {
            int digit=number%10;
            arr[index++]=digit;
            number=number/10;
        }

        Console.WriteLine("reverse of the number");
        for(int i =0;i<arr.Length;i++)
        {
            Console.WriteLine(arr[i]);
        }


    }
}