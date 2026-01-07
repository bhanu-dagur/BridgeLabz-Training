using System;
interface IRentable
{
    double CalculateRent(int days);
}

class Vehicle: IRentable
{
    protected string vehicleNumber;
    protected double rentPerDay;
    public Vehicle(string vehicleNumber, double rentPerDay)
    {
        this.vehicleNumber = vehicleNumber;
        this.rentPerDay = rentPerDay;
    }
    public virtual double CalculateRent(int days)
    {
        return rentPerDay * days;
    }
    public void DisplayVehicle()
    {
        Console.WriteLine("Vehicle Number: "+vehicleNumber);
        Console.WriteLine("Rent per day: "+rentPerDay);

    }
}

//  We directly use interface in the child class but we implement in parent
// class because in future next child class came we have remember to implement
class Bike : Vehicle  
{
    public Bike(string vehicleNumber) : base(vehicleNumber, 300)
    {
    }
    public override double CalculateRent(int days)
    {
        return rentPerDay * days;
    }
    
}
class Car : Vehicle 
{
    public  Car(string vehicleNumber) : base(vehicleNumber, 500)
    {
        
    }
    public override double CalculateRent(int days)
    {
        return (rentPerDay * days) + 1000;
    }
}
class Truck : Vehicle
{
    public Truck(string vehicleNumber) : base(vehicleNumber, 700)  {
        
    }
    public override double CalculateRent(int days)
    {
        return (rentPerDay * days) + 2000;
    }
}
class Customer
{
    string name;
    public Customer(string name)
    {
        this.name=name;
    }

    public void Rentvehicle(Vehicle v,int days)
    {
        Console.WriteLine("Customer Name: "+name);
        v.DisplayVehicle();
        Console.WriteLine("Days: "+days);
        Console.WriteLine("Total Rent: "+v.CalculateRent(days));
        Console.WriteLine("----------------------------");
    }
}
class VehicleRentalSystem
{
    static void Main()
    {
        Vehicle bike = new Bike("Bike123");
        Vehicle car = new Car("Car123");
        Vehicle truck = new Truck("Truck123");

        Customer customer = new Customer("Bhanu dagur");
        customer.Rentvehicle(bike, 5);
        customer.Rentvehicle(car, 5);
        customer.Rentvehicle(truck, 5);
    }
}



