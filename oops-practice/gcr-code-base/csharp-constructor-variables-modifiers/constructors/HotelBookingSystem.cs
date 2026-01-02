using System;

class HotelDetails
{
    string guestName;
    string roomType;
    int night;

    // Default constructor
    public HotelDetails()
    {
        guestName = "Bhanu Dagur";
        roomType = "Single";
        night = 2;
    }

    // Parameterized constructor
    public HotelDetails(string guestName, string roomType, int night)
    {
        this.guestName = guestName;
        this.roomType = roomType;
        this.night = night;
    }

    // Copy constructor
    public HotelDetails(HotelDetails h)
    {
        this.guestName = h.guestName;
        this.roomType = h.roomType;
        this.night = h.night;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("GUEST NAME : " + guestName);
        Console.WriteLine("ROOM TYPE : " + roomType);
        Console.WriteLine("NUMBER OF NIGHTS : " + night);
        Console.WriteLine("===============================");
    }
}

class HotelBookingSystem
{
    public static void Main()
    {
        HotelDetails h1 = new HotelDetails();
        Console.WriteLine("DEFAULT CONSTRUCTOR CALLED ");
        h1.DisplayDetails();

        HotelDetails h2 = new HotelDetails("Rohit", "Double", 3);
        Console.WriteLine("PARAMETERIZED CONSTRUCTOR CALLED ");
        h2.DisplayDetails();

        HotelDetails h3 = new HotelDetails(h2);
        Console.WriteLine("COPY CONSTRUCTOR CALLED ");
        h3.DisplayDetails();
    }
}
