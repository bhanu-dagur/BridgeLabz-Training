using System;

class BusStop
{
    string stopName;
    int stopNumber;
    int distanceFromPrevious;

    public BusStop(string stopName, int stopNumber, int distance)
    {
        this.stopName = stopName;
        this.stopNumber = stopNumber;
        this.distanceFromPrevious = distance;
    }

    public int GetDistance()
    {
        return distanceFromPrevious;
    }

    public void DisplayStopDetails()
    {
        Console.WriteLine("STOP NAME: " + stopName);
        Console.WriteLine("STOP NUMBER: " + stopNumber);
        Console.WriteLine("DISTANCE FROM PREVIOUS STOP: " + distanceFromPrevious + " KM");
        Console.WriteLine("-----------------------");
    }

    // returns true if passenger wants to get off
    public bool AskPassenger()
    {
        Console.WriteLine("CHOOSE 1 TO GET OFF AT THIS STOP");
        Console.WriteLine("CHOOSE 2 TO CONTINUE JOURNEY");

        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1)
        {
            return true;   // get off
        }
        else
        {
            return false;  // continue
        }
    }
}

class BusRoute
{
    static void Main(string[] args)
    {
        Console.WriteLine("ENTER THE NUMBER OF BUS STOPS:");
        int n = Convert.ToInt32(Console.ReadLine());

        BusStop[] busStops = new BusStop[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("ENTER DETAILS OF STOP " + (i + 1));

            Console.WriteLine("ENTER STOP NAME:");
            string name = Console.ReadLine();

            Console.WriteLine("ENTER STOP NUMBER:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER DISTANCE FROM PREVIOUS STOP (KM):");
            int distance = Convert.ToInt32(Console.ReadLine());

            busStops[i] = new BusStop(name, number, distance);
        }

        int totalDistance = 0;

        Console.WriteLine("\nJOURNEY STARTED...\n");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("YOU HAVE REACHED:");
            busStops[i].DisplayStopDetails();

            totalDistance = totalDistance + busStops[i].GetDistance();

            bool getOff = busStops[i].AskPassenger();

            if (getOff)
            {
                Console.WriteLine("PASSENGER GOT OFF");
                Console.WriteLine("TOTAL DISTANCE TRAVELLED: " + totalDistance + " KM");
                break;
            }
        }

        Console.WriteLine("JOURNEY ENDED");
    }
}
