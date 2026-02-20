using System;
class MainMenu
{
    public static void Show()
    {
    
        Console.WriteLine("\n-----HEALTH CLINIC APP-----");
        while (true)
        {
            Console.WriteLine("\n1.Patient Managemant");
            Console.WriteLine("2.Doctor Management");
            Console.WriteLine("3.Appointment Management");
            Console.WriteLine("4.Visit Management");
            Console.WriteLine("5.Billing Management");
            Console.WriteLine("6.Payment Management");
            Console.WriteLine("7.Audit Log Management");
            Console.WriteLine("0.Exit");

            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PatientMenu.Show();
                    break;
                case 2:
                    DoctorMenu.Show();
                    break;
                case 3:
                    AppointmentMenu.Show();
                    break;
                case 4:
                    VisitMenu.Show();
                    break;
                case 5: 
                    BillingMenu.Show();
                    break;
                case 6:
                    PaymentMenu.Show();
                    break;
                case 7:
                    AuditMenu.Show();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            
            }
            
        }
        Console.WriteLine("Goodbye!");
        
        
    }
}