using System;

// Circular Linked List Node
class TicketNode
{
    public int TicketId;
    public string CustomerName;
    public string MovieName;
    public string SeatNumber;
    public DateTime BookingTime;

    public TicketNode Next;

    public TicketNode(int id, string customer, string movie, string seat)
    {
        TicketId = id;
        CustomerName = customer;
        MovieName = movie;
        SeatNumber = seat;
        BookingTime = DateTime.Now;
        Next = null;
    }
}

// Circular Linked List
class TicketReservationSystem
{
    TicketNode head = null;
    TicketNode tail = null;

    // Add ticket at end
    public void AddTicket(int id, string customer, string movie, string seat)
    {
        TicketNode node = new TicketNode(id, customer, movie, seat);

        if (head == null)
        {
            head = tail = node;
            node.Next = head;
        }
        else
        {
            tail.Next = node;
            tail = node;
            tail.Next = head;
        }

        Console.WriteLine("Ticket booked successfully");
    }

    // Remove ticket by Ticket ID
    public void RemoveTicket(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode current = head;
        TicketNode previous = tail;

        do
        {
            if (current.TicketId == id)
            {
                // Only one node
                if (head == tail)
                {
                    head = tail = null;
                }
                else
                {
                    previous.Next = current.Next;

                    if (current == head)
                        head = current.Next;

                    if (current == tail)
                        tail = previous;
                }

                Console.WriteLine("Ticket removed");
                return;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        Console.WriteLine("Ticket not found");
    }

    // Display all tickets
    public void DisplayTickets()
    {
        if (head == null)
        {
            Console.WriteLine("No tickets to display");
            return;
        }

        TicketNode temp = head;
        Console.WriteLine("\n--- Booked Tickets ---");

        do
        {
            PrintTicket(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    // Search by Customer Name or Movie Name
    public void SearchTicket(string value)
    {
        if (head == null)
        {
            Console.WriteLine("No tickets booked");
            return;
        }

        TicketNode temp = head;
        bool found = false;

        do
        {
            if (temp.CustomerName.Equals(value, StringComparison.OrdinalIgnoreCase) ||
                temp.MovieName.Equals(value, StringComparison.OrdinalIgnoreCase))
            {
                PrintTicket(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
            Console.WriteLine("Ticket not found");
    }

    // Count total tickets
    public int CountTickets()
    {
        if (head == null) return 0;

        int count = 0;
        TicketNode temp = head;

        do
        {
            count++;
            temp = temp.Next;
        } while (temp != head);

        return count;
    }

    // Reusable print method
    void PrintTicket(TicketNode t)
    {
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Ticket ID     : " + t.TicketId);
        Console.WriteLine("Customer Name : " + t.CustomerName);
        Console.WriteLine("Movie Name    : " + t.MovieName);
        Console.WriteLine("Seat Number   : " + t.SeatNumber);
        Console.WriteLine("Booking Time  : " + t.BookingTime);
    }
}

// Main Class
class Program
{
    static void Main()
    {
        TicketReservationSystem system = new TicketReservationSystem();

        system.AddTicket(101, "Amit", "Avengers", "A1");
        system.AddTicket(102, "Rahul", "Avatar", "B3");
        system.AddTicket(103, "Neha", "Avengers", "C2");

        system.DisplayTickets();

        system.SearchTicket("Avengers");

        system.RemoveTicket(102);

        system.DisplayTickets();

        Console.WriteLine("\nTotal Booked Tickets: " + system.CountTickets());
    }
}
