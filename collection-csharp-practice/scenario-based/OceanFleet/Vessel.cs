using System.ComponentModel;
using System.Data.SqlTypes;

namespace OceanFleet;

class Vessel
{
    private string vesselId{get;set;}
    private string vesselName{get;set;}
    private double averageSpeed{get;set;}
    private string vesselType{get;set;}
    
    public Vessel(string vesselId,string vesselName,double averageSpeed,string vesselType)
    {
        this.vesselId=vesselId;
        this.vesselName=vesselName;
        this.averageSpeed=averageSpeed;
        this.vesselType=vesselType;
    }
    
    public string VesselId
    {
        get{ return vesselId;}
        set{vesselId=value;}
    }

    public string VesselName
    {
        get{return vesselName;}
        set{vesselName=value;}
    }

    public double AverageSpeed
    {
        set{averageSpeed=value;}
        get{return averageSpeed;}
    }

    public string VesselType
    {
        get{return vesselType;}
        set{vesselType=value;}
    }
}