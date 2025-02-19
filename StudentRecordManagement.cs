using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class StudentNode
{
    public int Id;
    public string FullName;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int id, string fullName, int age, char grade)
    {
        Id = id;
        FullName = fullName;
        Age = age;
        Grade = grade;
        Next = null;
    }
}

class StudentRecords
{
    private StudentNode head;

    public void AddStudentAtEnd(int id, string fullName, int age, char grade)
    {
        StudentNode newStudent = new StudentNode(id, fullName, age, grade);
        if (head == null)
        {
            head = newStudent;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newStudent;
    }

    public void RemoveStudent(int id)
    {
        if (head == null) return;

        if (head.Id == id)
        {
            head = head.Next;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.Id != id)
        {
            temp = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next = temp.Next.Next;
        }
    }

    public StudentNode FindStudent(int id)
    {
        StudentNode temp = head;
        while (temp != null)
        {
            if (temp.Id == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void ModifyGrade(int id, char newGrade)
    {
        StudentNode student = FindStudent(id);
        if (student != null)
        {
            student.Grade = newGrade;
        }
    }

    public void ShowStudents()
    {
        StudentNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.Id}, Name: {temp.FullName}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentRecords studentList = new StudentRecords();
        studentList.AddStudentAtEnd(101, "Alice Johnson", 20, 'A');
        studentList.AddStudentAtEnd(102, "Bob Smith", 22, 'B');
        studentList.ShowStudents();

        Console.WriteLine("Updating Bob's Grade...");
        studentList.ModifyGrade(102, 'A');
        studentList.ShowStudents();
    }
}
