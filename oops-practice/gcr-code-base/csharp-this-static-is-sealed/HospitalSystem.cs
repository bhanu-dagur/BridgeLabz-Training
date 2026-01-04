/*
Sample Program 7: Hospital Management System
Create a Patient class with the following features:
static: 
A static variable HospitalName shared among all patients.
A static method GetTotalPatients() to count the total patients admitted.
this: 
Use this to initialize Name, Age, and Ailment in the constructor.
readonly: 
Use a readonly variable PatientID to uniquely identify each patient.
is operator: 
Check if an object is an instance of the Patient class before displaying its details.
*/
using System;
class Patient
{
    static string HospitalName = "City Hospital";
    static int totalPatients = 0;

    public readonly int PatientID;
    public string Name;
    public int Age;
    public string Ailment;

    public Patient(int patientID, string name, int age, string ailment)
    {
        this.PatientID = patientID;
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        totalPatients++;
    }

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient ID: " + PatientID);
        Console.WriteLine("Patient Name: " + Name);
        Console.WriteLine("Patient Age: " + Age);
        Console.WriteLine("Patient Ailment: " + Ailment);
    }
}
class HospitalSystem
{
    public static void Main()
    {
        Patient patient1 = new Patient(101, "Bhanu dagur", 30, "Dangue");
        Patient patient2 = new Patient(102, "Rohit", 25, "Fever");

        if (patient1 is Patient)
        {
            patient1.DisplayDetails();
        }
        if (patient2 is Patient)
        {
            patient2.DisplayDetails();
        }

        Patient.GetTotalPatients();
    }
}