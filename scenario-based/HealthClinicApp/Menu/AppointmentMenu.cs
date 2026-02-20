public class AppointmentMenu
{
    private static AppointmentService service = new AppointmentService();

    public static void Show()
    {
        Console.WriteLine("\n--- APPOINTMENT MENU ---");
        Console.WriteLine("1. Book Appointment");
        Console.WriteLine("2. Cancel Appointment");
        Console.WriteLine("3. Reschedule Appointment");
        Console.WriteLine("4. View Daily Schedule");
        Console.WriteLine("5. Back");

        int ch = int.Parse(Console.ReadLine());

        switch (ch)
        {
            case 1: service.BookAppointment(); break;
            case 2: service.CancelAppointment(); break;
            case 3: service.Reschedule(); break;
            case 4: service.DailySchedule(); break;
            case 5: MainMenu.Show(); break;
        }
    }
}
