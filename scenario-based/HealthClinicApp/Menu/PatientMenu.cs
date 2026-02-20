using Microsoft.Extensions.DependencyInjection;
using System;
class PatientMenu
{
    static PatientService patientService=new PatientService();
    public static void Show()
    {
        Console.WriteLine("\n-----PATIENT MANAGEMENT-----");
        Console.WriteLine("1. Add Patient");
        Console.WriteLine("2. View Patient");
        Console.WriteLine("3. Delete Patient");
        Console.WriteLine("4. Search Patient");
        Console.WriteLine("5. Update Patient");
        Console.WriteLine("6. Back");

        int choice=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                patientService.AddPatient();

                break;
            case 2:
                patientService.ViewPatient();
                break;
            case 3:
                Console.WriteLine("Enter patientId to delete:");
                int patientId=Convert.ToInt32(Console.ReadLine());
                patientService.DeletePatient(patientId);
                break;
            case 4:
                Console.WriteLine("Enter patient name to search:");
                string Searchname=Console.ReadLine();
                patientService.SearchPatient(Searchname);
                break;
            case 5:
                Console.WriteLine("Enter patientId to update:");
                int patientId1=Convert.ToInt32(Console.ReadLine());
                Patient patient1 = new Patient();
                patient1.Id=patientId1;
                Console.WriteLine("Enetr Patient Name:");
                string name1=Console.ReadLine();
                patient1.Name=name1;

                Console.WriteLine("Enter Patient DOB:");
                string Dob1=Console.ReadLine();       
                patient1.DOB=Dob1;

                Console.WriteLine("Enter Patient Address:");
                string address1=Console.ReadLine();
                patient1.Address=address1;

                Console.WriteLine("Enter Patient Blood Group:");
                string bloodGroup1=Console.ReadLine();
                patient1.BloodGroup=bloodGroup1;

                Console.WriteLine("Enter Patient Phone Number:");
                string phone1=Console.ReadLine();
                patient1.Phone=phone1;

                Console.WriteLine("Enter Patient Email:");
                string email1=Console.ReadLine();
                patient1.Email=email1;

                patientService.UpdatePatient(patient1);
                break;
            case 6:
                MainMenu.Show();
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}