class DoctorServices
{
    public void AddDoctor(Doctor doctor)
    {
        DoctorUtility.Add(doctor);
        Console.WriteLine("Doctor Added sucessfully");
    }
    public void ViewDoctor()
    {
        DoctorUtility.View();
    }
    public void DeleteDoctor(int doctorId)
    {
        DoctorUtility.Delete(doctorId);
    }
    public void UpdateDoctor(Doctor doctor)
    {
        DoctorUtility.Update(doctor);
        Console.WriteLine("Doctor Updated sucessfully");
    }
    public void SearchDoctor(string name)
    {
        DoctorUtility.Search(name);
    }
}