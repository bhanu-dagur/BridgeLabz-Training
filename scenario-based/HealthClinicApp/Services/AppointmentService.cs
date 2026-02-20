class AppointmentService
{
    public void BookAppointment()
    {
        Appointment a=new Appointment();
        Console.WriteLine("Enter Patient Id:");
        a.PatientId=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Doctor Id:");
        a.DoctorId=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Appointment Date:");
        a.AppointmentDate=DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter Appointment Time:");
        a.AppointmentTime=TimeSpan.Parse(Console.ReadLine());

        AppointmentUtility.Book(a);
        Console.WriteLine("Appointment Booked Successfully");
    }
    public void CancelAppointment()
    {
        Console.WriteLine("Enter Appointment Id:");
        int appointmentId=int.Parse(Console.ReadLine());
        AppointmentUtility.Cancel(appointmentId);
        Console.WriteLine("Appointment Cancelled Successfully");
    }
    public void Reschedule()
    {
        Console.Write("Appointment ID: ");
        int id = int.Parse(Console.ReadLine());

        Console.Write("New Date: ");
        DateTime d = DateTime.Parse(Console.ReadLine());

        Console.Write("New Time: ");
        TimeSpan t = TimeSpan.Parse(Console.ReadLine());

        AppointmentUtility.Reschedule(id, d, t);
        Console.WriteLine("Appointment Rescheduled");
    }

    public void DailySchedule()
    {
        Console.Write("Date: ");
        DateTime d = DateTime.Parse(Console.ReadLine());

        var list = AppointmentUtility.GetDailySchedule(d);
        foreach (var item in list)
            Console.WriteLine(item);
    }
}