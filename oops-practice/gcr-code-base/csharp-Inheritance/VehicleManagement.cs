using System;
interface IRefuelable
{
    void Refuel();
}
class Vehicle
{
    int maxSpeed;
    string model;

    public Vehicle(int maxSpeed, String model)
    {
        this.maxSpeed = maxSpeed;
        this.model = model;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Max Speed: " + this.maxSpeed);
        Console.WriteLine("Model: " + this.model);
    }

}
class PetrolVehicle : Vehicle, IRefuelable
{
    public PetrolVehicle(int maxSpeed, String model) : base(maxSpeed, model)
    {
        
    }
    public void Refuel()
    {
        Console.WriteLine("Petrol refueled.");
    }
}
class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, String model) : base(maxSpeed, model)
    {
        
    }
    public void Charge()
    {
        Console.WriteLine("Electricity charged.");
    }
}
class VehicleManagement
{
    public static void Main(string[] args)
    {
        PetrolVehicle petrolVehicle = new PetrolVehicle(200, "Honda City");
        petrolVehicle.DisplayInfo();
        petrolVehicle.Refuel();

        ElectricVehicle electricVehicle = new ElectricVehicle(180, "Tesla Model 3");
        electricVehicle.DisplayInfo();
        electricVehicle.Charge();
    }
}
