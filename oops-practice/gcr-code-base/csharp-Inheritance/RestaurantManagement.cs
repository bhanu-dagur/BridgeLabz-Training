using System;
public interface IWorker
{
    void PerformDuties();
}
class People
{
    string name;
    int id;
    public People(string name, int id)
    {
        this.name = name;
        this.id = id;
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
    }
}
class Chef : People, IWorker
{
    public Chef(string name, int id) : base(name, id)
    {
        
    }
    public void PerformDuties()
    {
        Console.WriteLine("Chef is preparing food.");
    }
}
class Waiter : People, IWorker
{
    public Waiter(string name, int id) : base(name, id)
    {
        
    }
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving food.");
    }
}
class RestaurantManagement
{
    static void Main(string[] args)
    {
        Chef chef = new Chef("Alice", 1);
        Waiter waiter = new Waiter("Bob", 2);
        chef.DisplayDetails();
        chef.PerformDuties();
        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}