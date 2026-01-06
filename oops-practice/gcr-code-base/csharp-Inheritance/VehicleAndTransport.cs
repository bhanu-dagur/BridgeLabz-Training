using System;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
class Vehicle
{
    private int maxSpeed {get; set;}
    private string fuelType {get; set;}

    public Vehicle( int maxSpeed, string fuelType)
    {
        this.maxSpeed = maxSpeed;
        this.fuelType = fuelType;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + this.maxSpeed);
        Console.WriteLine("Fuel Type: " + this.fuelType);
    }
}
class Car: Vehicle{
    private int SeatCapacity {get; set;}
    public Car(int maxSpeed, string fuelType, int seatCapacity): base(maxSpeed, fuelType)
    {
        this.SeatCapacity = seatCapacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: " + this.SeatCapacity);
    }
}
class Truck: Vehicle
{
    private int PayloadCapacity {get; set;}
    public Truck(int maxSpeed, string fuelType, int payloadCapacity): base(maxSpeed, fuelType)
    {
        this.PayloadCapacity = payloadCapacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: " + this.PayloadCapacity);
    }
}
class Motorcycle: Vehicle
{
    private bool HasSidecar {get; set;}
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar): base(maxSpeed, fuelType)
    {
        this.HasSidecar = hasSidecar;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: " + this.HasSidecar);
    }
}
class VehicleAndTransport
{
    public static void Main()
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(180, "Petrol", 5);
        vehicles[1] = new Truck(120, "Diesel", 10000);
        vehicles[2] = new Motorcycle(160, "Petrol", false);

        foreach(Vehicle v in vehicles)
        {
            v.DisplayInfo();
            Console.WriteLine();
        }
    }
}