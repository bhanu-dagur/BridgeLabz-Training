using System;

// Abstract Class
abstract class Vehicle
{
    protected int vehicleNumber;
    protected string driverName;
    protected int ratePerKm;

    public Vehicle(int vehicleNumber, string driverName, int ratePerKm)
    {
        this.vehicleNumber = vehicleNumber;
        this.driverName = driverName;
        this.ratePerKm = ratePerKm;
    }

    public abstract void CalculateFare(double distance);

    public void GetVehicleDetails()
    {
        Console.WriteLine("Vehicle Details");
        Console.WriteLine("Vehicle Number : " + vehicleNumber);
        Console.WriteLine("Driver Name    : " + driverName);
        Console.WriteLine("Rate per Km    : " + ratePerKm);
        Console.WriteLine("======================");
    }
}

// Interface
interface IGPS
{
    void GetCurrentLocation();
    void UpdateLocation();
}

// Car Class
class Car : Vehicle, IGPS
{
    public Car(int vehicleNumber, string driverName, int ratePerKm)
        : base(vehicleNumber, driverName, ratePerKm) { }

    public override void CalculateFare(double distance)
    {
        double fare = distance * ratePerKm;
        Console.WriteLine("Car Fare : " + fare);
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Car current location fetched");
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Car location updated");
    }
}

// Bike Class
class Bike : Vehicle, IGPS
{
    public Bike(int vehicleNumber, string driverName, int ratePerKm)
        : base(vehicleNumber, driverName, ratePerKm) { }

    public override void CalculateFare(double distance)
    {
        double fare = distance * ratePerKm;
        Console.WriteLine("Bike Fare : " + fare);
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Bike current location fetched");
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Bike location updated");
    }
}

// Auto Class
class Auto : Vehicle, IGPS
{
    public Auto(int vehicleNumber, string driverName, int ratePerKm)
        : base(vehicleNumber, driverName, ratePerKm) { }

    public override void CalculateFare(double distance)
    {
        double fare = distance * ratePerKm;
        Console.WriteLine("Auto Fare : " + fare);
    }

    public void GetCurrentLocation()
    {
        Console.WriteLine("Auto current location fetched");
    }

    public void UpdateLocation()
    {
        Console.WriteLine("Auto location updated");
    }
}

// Main Class
class RideHailing
{
    public static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[3];
        vehicles[0] = new Car(101, "A", 10);
        vehicles[1] = new Bike(102, "B", 5);
        vehicles[2] = new Auto(103, "C", 15);

        foreach (Vehicle v in vehicles)
        {
            v.GetVehicleDetails();
            v.CalculateFare(10);

            // Interface Polymorphism
            IGPS gps = (IGPS)v;
            gps.GetCurrentLocation();
            gps.UpdateLocation();

            Console.WriteLine();
        }
    }
}
