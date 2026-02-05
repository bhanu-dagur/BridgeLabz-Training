using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanFleet;

class VesselUtil
{
    private List<Vessel> vesselList=new List<Vessel>();

    public List<Vessel> VesselList
    {
        get{return vesselList;}
        set{vesselList=value;}
    }

    public void AddVesselPerformance(Vessel vessel)
    {
        vesselList.Add(vessel);
        
    }

    public Vessel GetVesselById(string Id)
    {
        foreach(Vessel vessel in vesselList)
        {
            if (vessel.VesselId.Equals(Id))
            {
                return vessel;
            }
        }
        return null;
    }
    // Method to retrieve high performance vessel

    public List<Vessel> GetHighPerformanceVessels()
    {
        List<Vessel> ans=new List<Vessel>();

        if (vesselList.Count == 0)
        {
            return ans;
        }

        double maxSpeed=vesselList[0].AverageSpeed;

        foreach(Vessel vessel in vesselList)
        {
            if (vessel.AverageSpeed > maxSpeed)
            {
                maxSpeed=vessel.AverageSpeed;
            }
        }

        foreach(Vessel vessel in vesselList)
        {
            if (vessel.AverageSpeed == maxSpeed)
            {
                ans.Add(vessel);
            }
        }

        return ans;
    }

}