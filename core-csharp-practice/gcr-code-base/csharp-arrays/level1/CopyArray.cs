using System;
class CopyArray
{
    static void Main()
    {
        Console.WriteLine("Enter the number of row");
        int row=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of col");
        int col=Convert.ToInt32(Console.ReadLine());

        int [,] arr=new int [row,col];

        Console.WriteLine("Enter the value of the array ");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        int [] singleArr=new int[row*col];
        int idx=0;
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                singleArr[idx]=arr[i,j];
                idx++;
            }
        }
        
        Console.WriteLine(" The value stored in the single dimanesion form 2d array");

        for(int i = 0; i < row * col; i++)
        {
            
            Console.WriteLine(singleArr[i]);
        }
    }
}