class DoctorMenu{
    public static DoctorServices doctorServices=new DoctorServices();
    public static void Show()
    {
        Console.WriteLine("\n-----DOCTOR MANAGEMENT-----");
        Console.WriteLine("1. Add Doctor");
        Console.WriteLine("2. View Doctor");
        Console.WriteLine("3. Delete Doctor");
        Console.WriteLine("4. Search Doctor");
        Console.WriteLine("5. Update Doctor");
        Console.WriteLine("6. Back");

        int choice=Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Doctor doctor = new Doctor();
                Console.WriteLine("Enter Doctor name");
                string name=Console.ReadLine();
                doctor.doctorName=name;

                Console.WriteLine("Enter Doctor Specialization id");
                int specializationId=Convert.ToInt32(Console.ReadLine());
                doctor.specialtyId=specializationId;

                Console.WriteLine("Enter Doctor Phone");
                string phone=Console.ReadLine();
                doctor.contact=phone;

                Console.WriteLine("Enter Doctor consultation fee");
                double fee=Convert.ToDouble(Console.ReadLine());
                doctor.consultationFee=fee;

                doctorServices.AddDoctor(doctor);
                break;
            case 2:
                doctorServices.ViewDoctor();
                break;
            case 3:
                Console.WriteLine("Enter Doctor Id to delete");
                int id=Convert.ToInt32(Console.ReadLine());
                doctorServices.DeleteDoctor(id);
                break;
            case 4:
                Console.WriteLine("Enter Doctor name to search");
                string name1=Console.ReadLine();
                doctorServices.SearchDoctor(name1);
                break;
            case 5:
                Doctor doctor1 = new Doctor();
                Console.WriteLine("Enter Doctor Id to update");
                int id1=Convert.ToInt32(Console.ReadLine());
                doctor1.doctorId=id1;
                
                Console.WriteLine("Enter Doctor name");
                string name2=Console.ReadLine();
                doctor1.doctorName=name2;

                Console.WriteLine("Enter Doctor Specialization id");
                int specializationId1=Convert.ToInt32(Console.ReadLine());
                doctor1.specialtyId=specializationId1;

                Console.WriteLine("Enter Doctor Phone");
                string phone1=Console.ReadLine();
                doctor1.contact=phone1;

                Console.WriteLine("Enter Doctor consultation fee");
                double fee1=Convert.ToDouble(Console.ReadLine());
                doctor1.consultationFee=fee1;                

                doctorServices.UpdateDoctor(doctor1);
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