using System;

class HospitalNode
{
    public string name;
    public bool isAvailable;
    public HospitalNode next;

    public HospitalNode(string name, bool isAvailable)
    {
        this.name = name;
        this.isAvailable = isAvailable;
        this.next = null;
    }
}
class AmbulanceRoute
{
    private HospitalNode head;

    public void AddUnit(string name,bool IsAvailable)
    {
        HospitalNode newUnit=new HospitalNode(name,IsAvailable);

        if (head == null)
        {
            head=newUnit;
            newUnit.next=head;
            return;
        }

        HospitalNode temp=head;

        while (temp.next != head)
        {
            temp=temp.next;
        }

        temp.next=newUnit;
        newUnit.next=head;
    }

    public void DisplayRoute()
    {
        if (head == null)
        {
            Console.WriteLine("No Unit is in the hospital");
        }

        HospitalNode temp=head;

        while(temp.next != head)
        {
            Console.Write(temp.name+"-> ");
            temp=temp.next;
        }

        Console.Write(temp.name+"-> "+head.name);

    }
    public void FindNearestAvlUnit()
    {
        if (head == null)
        {
            Console.WriteLine("No unit is available ");
            return;

        }
        HospitalNode temp=head;

        do
        {
            if (temp.isAvailable)
            {
                Console.WriteLine("Nearest available unit "+temp.name);
                return;
            }
            temp=temp.next;
            
        }
        while(temp!=null);

        Console.WriteLine("No Unit is Availble is right now");
    }

    public void RemoveUnit(string name)
    {
    // Case 1: Empty list
        if (head == null)
        {
            Console.WriteLine("No unit is available");
            return;
        }

        // Case 2: Only one node
        if (head.next == head && head.name == name)
        {
            head = null;
            return;
        }

        // Case 3: More than one node
        HospitalNode temp = head;
        while (temp.next != head)
        {
            if (temp.next.name == name)
            {
                temp.next = temp.next.next;
                return;
            }
            temp = temp.next;
        }

        if (temp.next.name == name)
        {
            temp.next = temp.next.next;
            return;
        }

        // Case 4: Not found
        Console.WriteLine(name + " unit is not found");
    }

    
}

     

class RouteNavigation
{
    public static void Main()
    {
        AmbulanceRoute obj =new AmbulanceRoute();
        obj.AddUnit("Emergency",false);
        obj.AddUnit("Radiology",true);
        obj.AddUnit("Surgery",true);
        obj.AddUnit("ICU ",true);

        Console.WriteLine("Hospital Route:");
        obj.DisplayRoute();

        Console.WriteLine("\nIncaming Pateint");
        obj.FindNearestAvlUnit();

        Console.WriteLine("ICU is in the maintinance");
        obj.RemoveUnit("ICU ");

        Console.WriteLine("Updated Hospital route");
        obj.DisplayRoute();

        Console.WriteLine("\nIncaming Pateint");
        obj.FindNearestAvlUnit();
    }
}