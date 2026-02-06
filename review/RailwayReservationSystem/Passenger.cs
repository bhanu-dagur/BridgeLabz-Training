namespace RailwayReservationSystem;

class Passenger
{
     private string id;
    private string name;
    private int age;
   

    public Passenger(string id,string name, int age)
    {
        this.name = name;
        this.age = age;
        this.id = id;
    }

    public string Name
    {
        set{name=value;}
        get{return name;}
    }
    public int Age
    {
        set{age=value;}
        get{return age;}
    }
    public string Id
    {
        set{id=value;}
        get{return id;}
    }

    public override string ToString()
    {
        return "Id: "+id+" | Name: "+name+" |Age: "+age;
    }
    

    
    
}