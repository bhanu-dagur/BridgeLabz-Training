using System;
class Registration{
    string ownerName;
    string vehicalType;
    static int regitrationFee=500;
    public Registration(string ownerName,string vehicalType){
        this.ownerName=ownerName;
        this.vehicalType=vehicalType;
    }
    public void DisplayDetails(){
        Console.WriteLine("OWNER NAME: "+ownerName);
        Console.WriteLine("VEHICAL TYPE: "+vehicalType);
        Console.WriteLine("REGISTRATION FEE: "+regitrationFee);
    }
    public void UpdateRegistrationFee(int fee){
        regitrationFee=fee;
        Console.WriteLine("REGISTRATION FEE AFTER UPDATION: "+regitrationFee);
    }
}
class VehicalRegistration{
    static void Main(string[] args){
        Registration r=new Registration("Raj","Car");
        r.DisplayDetails();
        r.UpdateRegistrationFee(1000);
    }
}