namespace OceanFleet;
using System;
using System.Collections.Generic;

class UserInterFace
{
    public static void Main()
    {
        VesselUtil vesselUtil=new VesselUtil();
        Console.WriteLine("Enter the number of Vessel to be added");
        int n=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter vessel Deatils");
        for(int i = 0; i < n; i++)
        {
            string vesselDetail=Console.ReadLine();
            string[] detail=vesselDetail.Split(':');
        

            Vessel obj=new Vessel(detail[0],detail[1],Convert.ToDouble(detail[2]),detail[3]);
            vesselUtil.AddVesselPerformance(obj);
        }

        Console.WriteLine("Enter the Vessel Id to check speed");
        string id=Console.ReadLine();

        Vessel vessel=vesselUtil.GetVesselById(id);
        if (vessel != null)
        {
            Console.WriteLine(vessel.VesselId+" | "+vessel.VesselName+" | "+vessel.AverageSpeed+" | "+vessel.VesselType);
        }
        else
        {
            Console.WriteLine("Vessel Id "+id+" not found");
        }


        Console.WriteLine("High performance vessels are");
        List<Vessel> highPerf=vesselUtil.GetHighPerformanceVessels();
        foreach(Vessel data in highPerf)
        {
            Console.WriteLine(data.VesselId+" | "+data.VesselName+" | "+data.VesselType+" | "+data.AverageSpeed+" Knots");
        } 

         

    }
}