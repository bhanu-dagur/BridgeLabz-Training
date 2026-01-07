using System;
using System.Collections.Generic;
interface IMedicalRecord
{
    void AddRecord(string diagnosis);
    void ViewRecords();
}

abstract class Patient
{
    private int patientId;
    private string name;
    private int age;

    protected List<string> medicalHistory = new List<string>();

    public Patient(int patientId, string name, int age)
    {
        this.patientId = patientId;
        this.name = name;
        this.age = age;
    }

    public int PatientId
    {
        get { return patientId; }
    }

    public string Name
    {
        get { return name; }
    }

    public int Age
    {
        get { return age; }
    }

    // Abstract method
    public abstract double CalculateBill();

    // Concrete method
    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID : " + patientId);
        Console.WriteLine("Name       : " + name);
        Console.WriteLine("Age        : " + age);
    }
}

// IN-PATIENT 
class InPatient : Patient, IMedicalRecord
{
    private int daysAdmitted;
    private double dailyCharge;

    public InPatient(int id, string name, int age, int daysAdmitted, double dailyCharge)
        : base(id, name, age)
    {
        this.daysAdmitted = daysAdmitted;
        this.dailyCharge = dailyCharge;
    }

    public override double CalculateBill()
    {
        return daysAdmitted * dailyCharge;
    }

    public void AddRecord(string diagnosis)
    {
        medicalHistory.Add(diagnosis);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History (In-Patient):");
        foreach (string record in medicalHistory)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// OUT-PATIENT 
class OutPatient : Patient, IMedicalRecord
{
    private double consultationFee;

    public OutPatient(int id, string name, int age, double consultationFee)
        : base(id, name, age)
    {
        this.consultationFee = consultationFee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }

    public void AddRecord(string diagnosis)
    {
        medicalHistory.Add(diagnosis);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical History (Out-Patient):");
        foreach (string record in medicalHistory)
        {
            Console.WriteLine("- " + record);
        }
    }
}

// MAIN SYSTEM 
class HospitalManagementSystem
{
    static void Main()
    {
        // Polymorphism
        List<Patient> patients = new List<Patient>
        {
            new InPatient(101, "Bhanu", 22, 5, 2000),
            new OutPatient(102, "Rohit", 30, 800)
        };

        foreach (Patient patient in patients)
        {
            patient.GetPatientDetails();
            if (patient is IMedicalRecord)
            {
                IMedicalRecord record = (IMedicalRecord)patient;
                record.AddRecord("General Checkup");
                record.AddRecord("Prescribed Medicines");
                record.ViewRecords();
            }

            // Polymorphic billing
            Console.WriteLine("Total Bill : " + patient.CalculateBill());
            Console.WriteLine("----------------------------------");
        }
    }
}
