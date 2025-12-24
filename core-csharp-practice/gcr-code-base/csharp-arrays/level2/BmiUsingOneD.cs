using System;
class BmiUsingOneD
{
    static void Main()
    {
        Console.WriteLine("Enter the number of the persons");
        int noOfPerson=Convert.ToInt32(Console.ReadLine());

        // Create arrays to store the weight, height, BMI, and weight status of the persons
        double [] weight=new double[noOfPerson];
        double [] height=new double[noOfPerson];
        double [] bmi=new double[noOfPerson];
        String [] status=new String[noOfPerson];

        
        for(int i = 0; i < height.Length; i++)
        {
            Console.WriteLine("enter the height of the persons "+i);
            height[i]=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the weight of the persons "+i);
            weight[i]=Convert.ToDouble(Console.ReadLine());

            //calculate bmi and store in the bmi array

            bmi[i]=weight[i]/(height[i]*height[i]);

            if(bmi[i]<=18.5)  status[i]="Underweight";
            else if(bmi[i]>18.5 && bmi[i]<=25.0)   status[i]="Normal";
            else if(bmi[i]>25.0 && bmi[i]<40.0)   status[i]="OverWeight";
            else    status[i]="Obese";
        }

        for(int i = 0; i < noOfPerson; i++)
        {
            Console.WriteLine("Weight of the person "+ i +" is "+ weight[i]);
            Console.WriteLine("height of the person "+ i +" is "+ height[i]);
            Console.WriteLine("BMI of the person "+ i +" is "+ bmi[i]);
            Console.WriteLine("BMI Status of the person "+ i +" is "+ status[i]);
        }

    }
}