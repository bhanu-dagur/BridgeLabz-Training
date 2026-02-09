using FutureLogistics;
using System;


public class UserInterface
{
    public static void Main(string[] args)
    {
        Utility util = new Utility();

        Console.WriteLine("Enter the Goods Transport details");
        string input = Console.ReadLine();

        string transportId = input.Split(':')[0];

        if (!util.ValidateTransportId(transportId))
        {
            Console.WriteLine("Please provide a valid record");
            return;
        }

        GoodsTransport gt = util.ParseDetails(input);
        string type = util.FindObjectType(gt);

        Console.WriteLine($"\nTransporter id : {gt.TransportId}");
        Console.WriteLine($"Date of transport : {gt.TransportDate}");
        Console.WriteLine($"Rating of the transport : {gt.TransportRating}");

        if (type == "BrickTransport")
        {
            BrickTransport bt = (BrickTransport)gt;
            Console.WriteLine($"Quantity of bricks : {bt.BrickQuantity}");
            Console.WriteLine($"Brick price : {bt.BrickPrice}");
        }
        else
        {
            TimberTransport tt = (TimberTransport)gt;
            Console.WriteLine($"Type of the timber : {tt.TimberType}");
            Console.WriteLine($"Timber price per kilo : {tt.TimberPrice}");
        }

        Console.WriteLine($"Vehicle for transport : {gt.VehicleSelection()}");
        Console.WriteLine($"Total charge : {gt.CalculateTotalCharge()}");
    }
}
