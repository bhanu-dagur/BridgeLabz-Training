namespace FutureLogistics;

abstract class GoodsTransport
{
    protected string transportId;
    protected string transportDate;
    protected int transportRating;

    public GoodsTransport(string transportId, string transportDate, int transportRating)
    {
        this.transportId = transportId;
        this.transportDate = transportDate;
        this.transportRating = transportRating;
    }

    public string TransportId
    {
        get{return transportId;}
        set{TransportId=value;}
    }

    public string TransportDate
    {
        get{return transportDate;}
        set{TransportDate=value;}
    }

    public int TransportRating
    {
        set{transportRating=value;}
        get{return transportRating;}
    }

    abstract public string VehicleSelection();

    abstract public float CalculateTotalCharge();

}