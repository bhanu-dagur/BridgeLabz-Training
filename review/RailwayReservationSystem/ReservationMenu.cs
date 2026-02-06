namespace RailwayReservationSystem;

class ReservationMenu
{
    public void Menu()
    {
        ReservationsUtiltityImpl obj=new ReservationsUtiltityImpl();   
        Console.WriteLine("\n*********WELCOME TO RAILWAY RESERVATION SYSTEM*********");
        while (true)
        {
            Console.WriteLine("\nEnter 1 to book a ticket");
            Console.WriteLine("Enter 2 to cancel a ticket");
            Console.WriteLine("Enter 3 to display all tickets");
            Console.WriteLine("Enter 4 to exit");
            int choose =Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Enter your id");
                    string id=Console.ReadLine();
                    Console.WriteLine("Enter your name");
                    string name=Console.ReadLine();
                    Console.WriteLine("Enter your age");
                    int age=Convert.ToInt32(Console.ReadLine());
                    
                    obj.BookTicket(new Passenger(id,name,age));
                    break;
                case 2:
                    Console.WriteLine("Enter your id");
                    id=Console.ReadLine();
                    obj.CancelTicket(id);
                    break;
                case 3:
                    obj.DisplayTicket();
                    break;
                case 4:
                    Console.WriteLine("Thanks for using our services");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}