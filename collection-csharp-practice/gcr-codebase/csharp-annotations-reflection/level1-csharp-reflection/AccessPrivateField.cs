using System;
using System.Reflection;


// class Person
// {
//     private string name;
//     private int age;
   
//     public void ShowDetails()
//     {
//         Console.WriteLine("Age: " + age);
//     }
// }
// class AccessPrivateField
// {
//     public static void Main()
//     {
//         Person p=new Person();

//         Type type=p.GetType();

//         // get the private field
//         FieldInfo field=type.GetField("age",BindingFlags.NonPublic| BindingFlags.Instance);

//         // set the value of private field
//         field.SetValue(p,25);

//         // get value from private field
//         int ageValue=(int)field.GetValue(p);

//         Console.WriteLine("Age retrieved from private field: {0}",ageValue);

//         // verify using method
//         p.ShowDetails();


        
//     }
// }

class Person
{
    private string name;
    private int age;
    private string address;

    public void ShowDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Address: " + address);
    }
}

class AccessPrivateField
{
    public static void Main()
    {
        Person p=new Person();

        Type type=p.GetType();

        FieldInfo[] fields=type.GetFields(
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        foreach(FieldInfo field in fields)
        {
            if (field.Name == "name")
            {
                field.SetValue(p,"Bhanu");
            }

            else if (field.Name == "age")
            {
                field.SetValue(p,23);
            }
            else if (field.Name == "address")
            {
                field.SetValue(p,"jadana");
            }
        }

        Console.WriteLine("Values retrieved from the reflection");

        foreach(FieldInfo field in fields)
        {
            Console.WriteLine(field.Name+" = "+field.GetValue(p));
        }

        Console.WriteLine("Value retrieved from People");
        p.ShowDetails();
    }
}