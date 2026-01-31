using System;
using System.Reflection;

// [AttributeUsage] is not mandatory, but it is a best practice because it restricts 
// where an attribute can be applied and prevents incorrect usage at compile time.

[AttributeUsage(AttributeTargets.Class)]

// [AttributeUsage(AttributeTargets.Class)] specifies that a custom attribute can be applied only to classes. 
// It restricts the usage of the attribute to class-level elements and prevents it from being used on methods, properties, or other code elements

class AuthorAttribute : Attribute // custom attribute and inherits parent Attribute class
{
    public string Name;
    public AuthorAttribute(string name)
    {
        this.Name=name;
    }
}

// It is a custom attribute usage that assigns author information to a class as metadata, 
// which can be retrieved at runtime using Reflection.

[Author("Bhanu Dagur")]
//[AuhorAttribute("Bhanu Dagur")]   valid also

class Person
{
    public void ShowDetails()
    {
        // Attribute fields do not become class members. Attribute data is stored as metadata
        // and can only be accessed using Reflection, not directly inside the class.
        // Console.WriteLine("Name: " + Name); Error
        Console.WriteLine("Student Person");
    }
}

class RetrieveAttributes
{
    public static void Main()
    {
        Type type=typeof(Person);
        
        object [] attributes=type.GetCustomAttributes(false);

        foreach(object Attribute in attributes)
        {
            AuthorAttribute author=(AuthorAttribute)Attribute;
            Console.WriteLine(author.Name);
        }
    }
}

// Attributes are not created by developers manually.
// They are instantiated by the .NET runtime when Reflection is used.