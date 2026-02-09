using System.ComponentModel.DataAnnotations.Schema;
using FutureLogistics;

class TimberTransport : GoodsTransport
{
    private float timberLength;
    private float timberRadius;

    private string timberType;

    private float timberPrice;

    public float TimberLength
    {
        get{return timberLength;}
        set{timberLength=value;}
    
    }
    public float TimberRadius
    {
        get{return timberRadius;}
        set{timberRadius=value;}
    }
    public string TimberType
    {
        get{return timberType;}
        set{timberType=value;}
    }
    public float TimberPrice
    {
        get{return timberPrice;}
        set{timberPrice=value;}
    }

    public TimberTransport(string transportId, string transportDate, int transportRating, float timberLength, float timberRadius, string timberType, float timberPrice) : base(transportId, transportDate, transportRating)
    {
        this.timberLength = timberLength;
        this.timberRadius = timberRadius;
        this.timberType = timberType;
        this.timberPrice = timberPrice;
    }

    public override string VehicleSelection()
    {
        float area=2*3.147f*timberRadius*timberLength;
        if (area < 250)
        {
            return "Truck";
        }
        else if(area>=250 && area <= 400)
        {
            return "Lorry";
        }
        else
        {
            return "MonsterLorry";
        }
        
    }
    public override float CalculateTotalCharge()
    {
        float volume=3.147f*timberRadius*timberRadius*timberLength;
        float timberTypePrice=TimberTypePrice();
        float price=volume*timberPrice*timberTypePrice;

        float tax=price*0.3f;
        float discountpercent=RatingDiscount();

        float discountPrice=price*discountpercent/100;
        float totalCost=price+VehiclePrice(VehicleSelection())+tax-discountPrice;

        return totalCost;

    }
    public float VehiclePrice(string VehicelType)
    {
        if (VehicelType.Equals("Truck", StringComparison.OrdinalIgnoreCase))
        {
            return 1000;
        }
        else if (VehicelType.Equals("Lorry", StringComparison.OrdinalIgnoreCase))
        {
            return 1700;
        }
        else
        {
            return 3000;
        }
    }
    public float RatingDiscount()
    {
        if (transportRating == 5)
        {
            return 20;
        }
        else if (transportRating == 3 ||transportRating == 4)
        {
            return 10;
        }
        else
        {
            return 0;
        }
    }

    public float TimberTypePrice()
    {
        if (timberType.Equals("premium", StringComparison.OrdinalIgnoreCase))
        {
            return 0.25f;
        }
        else
        {
            return 0.15f;
        }
    }
}