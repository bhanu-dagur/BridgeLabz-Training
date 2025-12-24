using System;
class BmiUsingOneD
{
    static void Main()
    {
        Console.WriteLine("Enter the number of the persons");
        int noOfPerson=Convert.ToInt32(Console.ReadLine());

        // Create arrays to store the weight, height, BMI, and weight status of the persons
        double [,] personData=new double[noOfPerson,3];
        // index 0=height,index 1=weight,index 2=bmi
        String [] status=new String[noOfPerson];

        
        for(int i = 0; i < noOfPerson; i++)
        {
            Console.WriteLine("enter the height of the persons "+(i+1));
            personData[i,0]=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the weight of the persons "+(i+1));
            personData[i,1]=Convert.ToDouble(Console.ReadLine());

            //calculate bmi and store in the bmi array

            personData[i,2]=personData[i,1]/(personData[i,0]*personData[i,0]);

            if(personData[i,2]<=18.5)  status[i]="Underweight";
            else if(personData[i,2]>18.5 && personData[i,2]<=25.0)   status[i]="Normal";
            else if(personData[i,2]>25.0 && personData[i,2]<40.0)   status[i]="OverWeight";
            else    status[i]="Obese";
        }

        for(int i = 0; i < noOfPerson; i++)
        {
            Console.WriteLine("Weight of the person "+ (i+1) +" is "+ personData[i,1]);
            Console.WriteLine("height of the person "+ (i+1) +" is "+ personData[i,0]);
            Console.WriteLine("BMI of the person "+ (i+1 )+" is "+ personData[i,2]);
            Console.WriteLine("BMI Status of the person "+ (i+1) +" is "+ status[i]);
        }

    }
}