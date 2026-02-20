public class PatientService 
{
    public  void AddPatient()
    {
        Patient patient = new Patient();
        Console.WriteLine("Enter Patient Name: ");
        patient.Name = Console.ReadLine();
        Console.WriteLine("Enter Patient DOB: ");
        patient.DOB = (Console.ReadLine());
        Console.WriteLine("Enter Patient Address: ");
        patient.Address = Console.ReadLine();
        Console.WriteLine("Enter Patient BloodGroup: ");
        patient.BloodGroup = Console.ReadLine();
        Console.WriteLine("Enter Patient Phone: ");
        patient.Phone = Console.ReadLine();
        Console.WriteLine("Enter Patient Email: ");
        patient.Email = Console.ReadLine();
    
        PatientUtility.Add(patient);
        Console.WriteLine("Patient Added sucessfully");
    }
    public void ViewPatient()
    {
        PatientUtility.View();
    }
    public void DeletePatient(int patientId)
    {
        PatientUtility.Delete(patientId);
    }
    public void UpdatePatient(Patient patient)
    {
        PatientUtility.Update(patient);
        Console.WriteLine("Patient Updated sucessfully");
    }
    public void SearchPatient(string name)
    {
        PatientUtility.Search(name);
    }
    
    

}