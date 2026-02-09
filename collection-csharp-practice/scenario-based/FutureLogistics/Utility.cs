using FutureLogistics;      
using System;
using System.Text.RegularExpressions;
class Utility
{
    public GoodsTransport ParseDetails(string input)
    {
        string[] data=input.Split(':');
        string transportId=data[0];
        string date=data[1];
        int rating=int.Parse(data[2]);
        string type=data[3];

        if (type.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
        {
            int brickSize=int.Parse(data[4]);
            int quantity=int.Parse(data[5]);
            float price=float.Parse(data[6]);
            return new BrickTransport(brickSize, quantity, price, transportId, date, rating);
        }
        else if (type.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase))
        {
            float length=float.Parse(data[4]);
            float radius=float.Parse(data[5]);
            string timberType=data[6];
            float price=float.Parse(data[7]);
            return new TimberTransport(transportId, date, rating, length, radius, timberType, price);
        }
        return null;
        
    }
    public Boolean ValidateTransportId(string tansportId)
    {
        if(Regex.IsMatch(tansportId,@"^RTS[0-9]{3}[A-Z]$"))
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public string FindObjectType(GoodsTransport goodsTransport)
    {
        if(goodsTransport is BrickTransport)
        {
            return "BrickTransport";
        }
        else if(goodsTransport is TimberTransport)
        {
            return "TimberTransport";
        }
        else
        {
            return "object not found";
        }
    }
}