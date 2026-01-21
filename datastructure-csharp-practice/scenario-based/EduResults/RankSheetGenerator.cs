
using System;
using System.Data;
using System.Globalization;

class RankSheetGenerator
{
    static void Main()
    {
        Console.WriteLine("Enter the number of district: ");
        int numOfDistrict = Convert.ToInt32(Console.ReadLine());  
        
        //jagged array
        int [][] studentMarks=new int[numOfDistrict][];
        for(int i = 0; i < numOfDistrict; i++)
        {
            Console.WriteLine("Enter the number of students in district : "+(i+1));
            int numOfStudents = Convert.ToInt32(Console.ReadLine());  
            studentMarks[i]=new int[numOfStudents];
            Console.WriteLine("Enter the marks of "+numOfStudents+" students in district : "+(i+1));
            for(int j = 0; j < numOfStudents; j++)
            {
                studentMarks[i][j]=Convert.ToInt32(Console.ReadLine()); 
            }
            
            
        }
        int [] rankSheet=new RankSheetGenerator().GetRankSheet(studentMarks);
        for(int i =rankSheet.Length-1;i>=0;i--)
        {
            Console.WriteLine("Student marks "+rankSheet[i] +" has rank "+(rankSheet.Length-i));
        }


    }
    public int [] GetRankSheet(int [][] studentMarks)
    {
        int [] temp=studentMarks[0];
        for(int i = 0; i < studentMarks.Length; i++)
        {
            temp=MergeSort(temp,studentMarks[i]);
        }
        return temp;
    }

    public int[] MergeSort(int [] arr1,int[] arr2)
    {
        int [] result=new int[arr1.Length+arr2.Length];
        int i=0,j=0,k=0;
        while(i<arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                result[k++]=arr1[i++];
            }
            else
            {
                result[k++]=arr2[j++];
            }
        }

        while (i < arr1.Length)
        {
            result[k++]=arr1[i++];

        }

        while (j < arr2.Length)
        {
            result[k++]=arr2[j++];
        }
        return result;
        
    }
}