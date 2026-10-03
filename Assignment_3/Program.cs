using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwaSaeed_Assignment3
{
    public class Person
    {
        public string Name { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Name:"+Name);
        }
    }
    public class Student : Person
    {
        public int StudentId { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}  StudentId:{StudentId}");
        }

    }
    public class Employee : Person
    {
        public int Salary { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}  Salary: {Salary}");
        }
    }
    public class Teacher : Person
    {
        public string CourseName { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Name:{Name}  CourseName: {CourseName}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>()
            {
              new Student
              {
                  Name = "Marwa",
                  StudentId = 45657869
              },
              new Employee
              {
                  Name = "Aseel",
                  Salary = 560000
              },
              new Teacher
              {
                  Name = "Ahmed",
                  CourseName = "OOP"
              },

            }; 
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.GetType()}");
                person.DisplayInfo();
            }
        }
    }
}
