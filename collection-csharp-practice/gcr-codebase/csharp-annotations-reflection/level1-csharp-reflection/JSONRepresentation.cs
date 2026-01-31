using System;
using System.Reflection;
using System.Text;


class Student
{
    public int id;
    public string name;
    public int age;

    public Student(int id,string name,int age)
    {
        this.id=id;
        this.name=name;
        this.age=age;
    }
}
class JSONGenerator
{
    public static string ToJSON(object obj)
    {
        Type type=obj.GetType();
        FieldInfo [] fields=type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        StringBuilder json=new StringBuilder();
        json.Append("{\n");

        foreach(FieldInfo field in fields)
        {
            object value=field.GetValue(obj);
            
            json.Append("\t\""+field.Name+"\" : ");

            if(value is string)
            {
                json.Append("\""+value+"\"");
            }
            else
            {
                json.Append(value);
            }
            if(field!=fields[fields.Length-1])
            {
                json.Append(",\n");
            }
        }  
        json.Append("\n}");
        return json.ToString();
        
    }
}

class JSONRepresentation
{
    public static void Main()
    {
        Student student =new Student(001,"Bhanu Dagur",22);
        
        string ans=JSONGenerator.ToJSON(student);

        Console.WriteLine(ans);


    }
}