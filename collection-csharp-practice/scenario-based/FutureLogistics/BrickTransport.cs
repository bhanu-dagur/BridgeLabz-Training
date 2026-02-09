namespace FutureLogistics;

class BrickTransport : GoodsTransport
{
    private float brickSize;
    private int brickQuantity;
    private float brickPrice;

    public BrickTransport(float brickSize, int brickQuantity, float brickPrice, string transportId, string transportDate, int transportRating) : base(transportId, transportDate, transportRating)
    {
        this.brickSize = brickSize;
        this.brickQuantity = brickQuantity;
        this.brickPrice = brickPrice;
    }
    public float BrickSize { get => brickSize; set => brickSize = value; }
    public int BrickQuantity { get => brickQuantity; set => brickQuantity = value; }
    public float BrickPrice { get => brickPrice; set => brickPrice = value; }

    public override string VehicleSelection()
    {
        if (brickQuantity < 300)
        {
            return "Truck";
        }
        else if(brickQuantity>=300 && brickQuantity <= 500)
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
        float price=brickPrice*brickQuantity;
        string vehicleType=VehicleSelection();
        float vehiclePrice=VehiclePrice(vehicleType);

        float tax=price*0.3f;
        int discountpercent=RatingDiscount();

        float discountPrice=price*discountpercent/100;
        float totalCost=price+tax+vehiclePrice-discountPrice;

        return totalCost;


    }
    public int RatingDiscount()
    {
        if (transportRating== 5)
        {
            return 20;
        }
        else if(transportRating==3 || transportRating == 4)
        {
            return 10;
        }
        else
        {
            return 0;
        }

    }
    public int VehiclePrice(string VehicelType)
    {
        if(VehicelType.Equals("Truck",StringComparison.OrdinalIgnoreCase))
        {
            return 1000;
        }
        else if(VehicelType.Equals("Lorry",StringComparison.OrdinalIgnoreCase))
        {
            return 1700;
        }
        else
        {
            return 3000;
        }
    }
}