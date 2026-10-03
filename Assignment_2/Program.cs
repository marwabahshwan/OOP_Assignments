using MarwaSaeed_Assignment2;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwaSaeed_Assignment2
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Person(string name, string email)
        {
            Name = name;
            Email = email;
            Console.WriteLine("person constructor executed");
        }
        public void DisplayBasicInfo()
        {
            Console.WriteLine($" Name: {Name}");
            Console.WriteLine($" Email: {Email}");
           
        }

    }
      public class Student : Person
    {
        public int StudentId { get; set; }
        public double GPA { get; set; }
        public Student(string name, string email, int studentId, double gpa) : base(name, email)
        {
            StudentId = studentId;
            GPA = gpa;
            Console.WriteLine(" Student constructor executed");
        }

    }
    }
    public class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public Employee(string name, string email, int employeeId, double salary) : base(name, email)
        {
            EmployeeId = employeeId;
            Salary = salary;
        Console.WriteLine("Employee constructor executed");
        }

    }
    public class Teacher : Employee
    {
        public string CourseName { get; set; }
        public Teacher(string name, string email, int employeeId, double salary, string coursename) : base(name, email, employeeId, salary)
        {
            CourseName = coursename;
        Console.WriteLine("Teacher constructor executed");
        }

        public void Teach()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student ("Marwa","marwa@uni.com",546909,4.5);
            student.DisplayBasicInfo();
            Console.WriteLine("StudentId: "+student.StudentId);
            Console.WriteLine("GPA: "+student.GPA);
            Teacher teacher = new Teacher ("Saeed","saeed@uni.com",88976,43500,"OOP");
            teacher.DisplayBasicInfo();
            Console.WriteLine("TeacherId: "+teacher.EmployeeId);
            Console.WriteLine("The Salary: "+teacher.Salary);
            Console.WriteLine("Course Name: "+teacher.CourseName);
        }
    }

