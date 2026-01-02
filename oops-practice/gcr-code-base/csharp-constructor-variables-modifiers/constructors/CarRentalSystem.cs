using System;
class CarRental{
    string customerName;
    string carModel;
    int rentaldays;
    public CarRental(string customerName,string carModel,int rentaldays){
        this.customerName=customerName;
        this.carModel=carModel;
        this.rentaldays=rentaldays;
    }
    public void Display(){
        Console.WriteLine("CUSTOMER NAME: "+customerName);
        Console.WriteLine("CAR MODEL: "+carModel);
        Console.WriteLine("RENTAL DAYS: "+rentaldays);
    }
    public void CalculateRent(){
        Console.WriteLine("ENTER THE RENT PER DAY FOR THE CAR: "+carModel);
        int rentPerDay=Convert.ToInt32(Console.ReadLine());
        int totalRent=rentPerDay*rentaldays;
        Console.WriteLine("TOTAL RENT FOR "+rentaldays+" DAYS IS : "+totalRent);
    }
}
 class CarRentalSystem{
    public static void Main(){
        Console.WriteLine("ENTER THE CUSTOMER NAME");
        string name=Console.ReadLine();
        Console.WriteLine("ENTER THE CAR MODEL");
        string carModel=Console.ReadLine();
        Console.WriteLine("ENTER THE NUMBER OF THE DAYS");
        int days=Convert.ToInt32(Console.ReadLine());

        CarRental rental=new CarRental(name,carModel,days);

        rental.Display();
        rental.CalculateRent();


    }
}