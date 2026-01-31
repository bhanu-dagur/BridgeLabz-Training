using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Reflection;

class Student
{
    public string id;
    public string name;
    public int age;

}

class ObjectMapper
{
    public static T ToObject<T>(Type clazz,Dictionary<string,object> properties)
    {
        object obj=Activator.CreateInstance(clazz);

        FieldInfo [] fields=clazz.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach(FieldInfo field in fields)
        {
            if (properties.ContainsKey(field.Name))
            {
                field.SetValue(obj,properties[field.Name]);
            }
        }

        return (T)obj;
    }
}

class CustomObjectMapper
{
    public static void Main()
    {
        Dictionary<string, Object> dict =new Dictionary<string, object>()
        {
            {"id",001},
            {"name","bhanu"},
            {"age",25}
        };
        Type type=typeof(Student);

        Student student=ObjectMapper.ToObject<Student>(type,dict);

        Console.WriteLine("Student Id: "+student.id);   
        Console.WriteLine("Student Name: "+student.name);   
        Console.WriteLine("Student Age: "+student.age);
    }
}

/*
ObjectMapper.ToObject<Student>(...)
Calling a generic method
<Student> tells the compiler:

“The final object returned by this method should be of type Student.”

Without generics, we would get only object and need manual casting.

This statement calls a generic object-mapping method that uses Reflection to dynamically create 
an instance of the Student class at runtime. The typeof(Student) provides type metadata, 
and the dictionary supplies field values. The method populates the object’s fields and returns a 
strongly-typed Student object without using the new keyword.
*/