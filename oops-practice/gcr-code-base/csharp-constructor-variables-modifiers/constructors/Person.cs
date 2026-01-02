using System;
class Person{
    public static void Main(){
        Console.WriteLine("ENTER THE NAME OF PERSON");
        string name=Console.ReadLine();
        Console.WriteLine("ENTER THE AGE OF PERSON");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ENTER THE ADDRESS OF PERSON");
        string address=Console.ReadLine();

        PersonDetails person1=new PersonDetails(name,age,address);
        Console.WriteLine("DISPLAYING PERSON1 DETAILS");
        person1.DisplayDetails();

        Console.WriteLine(" ");
        PersonDetails person2=new PersonDetails(person1);
        Console.WriteLine("DISPLAYING PERSON DETAIL USING COPY CONSTRUCTOR ");
        person2.DisplayDetails();
    }
}
class PersonDetails{
    string name;
    int age;
    string address;
    //Parameterized
    public PersonDetails(string name,int age,string address)
    {
        this.name=name;
        this.age=age;
        this.address=address;
    }
    // copy constructor
    public PersonDetails(PersonDetails p){
        this.name=p.name;
        this.age=p.age;
        this.address=p.address;
    }
    public void DisplayDetails(){
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Address: "+address);
    }
}