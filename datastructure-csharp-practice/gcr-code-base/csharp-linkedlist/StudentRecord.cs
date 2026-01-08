
using System;

// Node class represents ONE student
class StudentNode
{
    public int RollNo;
    public string Name;
    public int Age;
    public string Grade;

    // Reference to next node
    public StudentNode Next;

    public StudentNode(int roll, string name, int age, string grade)
    {
        RollNo = roll;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null; // initially next is null
    }
}

// Linked list class
class StudentList
{
    // Head always points to first student
    private StudentNode head = null;

    // Add student at end
    public void AddStudent(int roll, string name, int age, string grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        // If list is empty
        if (head == null)
        {
            head = newNode;
            return;
        }

        // Traverse till last node
        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
    }

    // Delete student by roll number
    public void DeleteStudent(int roll)
    {
        if (head == null) return;

        // If head needs to be deleted
        if (head.RollNo == roll)
        {
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNo != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
            temp.Next = temp.Next.Next;
    }

    // Search student
    public void SearchStudent(int roll)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNo == roll)
            {
                Console.WriteLine("Student Found: " + temp.Name);
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found");
    }

    // Display all students
    public void DisplayStudents()
    {
        StudentNode temp = head;

        while (temp != null)
        {
            Console.WriteLine("Roll: " + temp.RollNo + ", Name: " + temp.Name + ", Age: " + temp.Age + ", Grade: " + temp.Grade);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentList list = new StudentList();

        list.AddStudent(1, "Bhanu dagur", 23, "A");
        list.AddStudent(2, "Devesh dagur", 19, "B");

        list.DisplayStudents();
        list.SearchStudent(1);
        list.DeleteStudent(2);
        list.DisplayStudents();
    }
}
