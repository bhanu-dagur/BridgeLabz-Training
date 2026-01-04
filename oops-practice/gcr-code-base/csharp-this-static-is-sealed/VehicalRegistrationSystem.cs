using System;

class Vehicle
{
    static double RegistrationFee = 1000.0;
    static int totalVehicles = 0;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.OwnerName = ownerName;
        this.VehicleType = vehicleType;
        this.RegistrationNumber = registrationNumber;
        totalVehicles++;
    }

    public static void UpdateRegistrationFee(double newFee)
    {
        RegistrationFee = newFee;
        Console.WriteLine("Registration fee updated to: " + RegistrationFee);
    }

    public void DisplayRegistrationDetails()
    {
        Console.WriteLine("Owner Name: " + OwnerName);
        Console.WriteLine("Vehicle Type: " + VehicleType);
        Console.WriteLine("Registration Number: " + RegistrationNumber);
        Console.WriteLine("Registration Fee: " + RegistrationFee);
    }
}

class VehicleRegistrationSystem
{
    public static void Main()
    {
        Vehicle vehicle1 = new Vehicle("Bhanu Dagur", "Car", "GLA123");
        Vehicle vehicle2 = new Vehicle("Devesh Dagur", "Bike", "GLA456");

        // Static method ko class name se call karna chahiye
        Vehicle.UpdateRegistrationFee(1500.0);

        // Check if an object belongs to the Vehicle class before displaying its registration details
        if (vehicle1 is Vehicle)
            vehicle1.DisplayRegistrationDetails();

        if (vehicle2 is Vehicle)
            vehicle2.DisplayRegistrationDetails();
    }
}