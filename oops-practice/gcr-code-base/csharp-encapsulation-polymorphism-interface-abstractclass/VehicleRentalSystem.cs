using System;
using System.Collections.Generic;
interface IInsurable
{
    double CalculateInsurance(int days);
    string GetInsuranceDetails();
}

// ABSTRACT CLASS 
abstract class Vehicle
{
    protected string vehicleNumber;
    protected string type;
    protected double rentalRate;

    private string insurancePolicyNumber;

    public Vehicle(string vehicleNumber, string type, double rentalRate, string policyNumber)
    {
        this.vehicleNumber = vehicleNumber;
        this.type = type;
        this.rentalRate = rentalRate;
        this.insurancePolicyNumber = policyNumber;
    }
    public string VehicleNumber
    {
        get { return vehicleNumber; }
    }

    public string Type
    {
        get { return type; }
    }

    // Abstract method
    public abstract double CalculateRentalCost(int days);

    public void DisplayVehicle()
    {
        Console.WriteLine("Vehicle Number : " + vehicleNumber);
        Console.WriteLine("Vehicle Type   : " + type);
        Console.WriteLine("Rate per Day   : " + rentalRate);
    }
}

class Car : Vehicle, IInsurable
{
    public Car(string number, double rate, string policy)
        : base(number, "Car", rate, policy) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days + 500; 
    }

    public double CalculateInsurance(int days)
    {
        return days * 200;
    }

    public string GetInsuranceDetails()
    {
        return "Car Insurance: ₹200/day";
    }
}

class Bike : Vehicle, IInsurable
{
    public Bike(string number, double rate, string policy)
        : base(number, "Bike", rate, policy) { }

    public override double CalculateRentalCost(int days)
    {
        return rentalRate * days;
    }

    public double CalculateInsurance(int days)
    {
        return days * 100;
    }

    public string GetInsuranceDetails()
    {
        return "Bike Insurance: ₹100/day";
    }
}

class Truck : Vehicle, IInsurable
{
    public Truck(string number, double rate, string policy)
        : base(number, "Truck", rate, policy) { }

    public override double CalculateRentalCost(int days)
    {
        return (rentalRate * days) + (days * 300); 
    }

    public double CalculateInsurance(int days)
    {
        return days * 400;
    }

    public string GetInsuranceDetails()
    {
        return "Truck Insurance: ₹400/day";
    }
}
class VehicleRentalSystem
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR-101", 1500, "CAR-INS-001"),
            new Bike("BIKE-202", 500, "BIKE-INS-002"),
            new Truck("TRUCK-303", 3000, "TRUCK-INS-003")
        };

        int days = 3;

        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayVehicle();

            double rentalCost = vehicle.CalculateRentalCost(days);
            double insuranceCost = 0;

            // Interface-based polymorphism
            if (vehicle is IInsurable)
            {
                IInsurable insurable = (IInsurable)vehicle;
                insuranceCost = insurable.CalculateInsurance(days);
                Console.WriteLine(insurable.GetInsuranceDetails());
            }

            Console.WriteLine("Days Rented    : " + days);
            Console.WriteLine("Rental Cost   : " + rentalCost);
            Console.WriteLine("Insurance Cost: " + insuranceCost);
            Console.WriteLine("Total Cost    : " + (rentalCost + insuranceCost));
            Console.WriteLine("----------------------------------");
        }
    }
}
