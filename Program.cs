using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwaSaeed_Assignment1
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }
        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public void Start()
        {
            Console.WriteLine("Stating up....");
        }

    }
    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, int year, int numberOfDoors) : base(brand, year)
        {

            NumberOfDoors = numberOfDoors;

        }

    }

    class Bus : Vehicle
    {
        public int Capacity { get; set; }

        public Bus(string brand, int year, int capacity) : base(brand, year)
        {

            Capacity = capacity;

        }

    }

    class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle(string brand, int year, bool hasSideCar) : base(brand, year)
        {
            HasSideCar = hasSideCar;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", 2025, 4);
            Console.WriteLine($"The Brand of Car is {car.Brand} Year: {car.Year} Doors: {car.NumberOfDoors}");
            car.Start();
            Bus bus = new Bus("Toyota", 2008, 16);
            Console.WriteLine($"The Brand of Bus is {bus.Brand} Year: {bus.Year} Capacity: {bus.Capacity}");
            bus.Start();

            Motorcycle motorcycle = new Motorcycle("Suzuki", 2023, false);
            string hasSideCar = motorcycle.HasSideCar ? "Yes" : "No";
            Console.WriteLine($"The Brand of Motorcycle is {motorcycle.Brand} Year: {motorcycle.Year} Has SideCar: {hasSideCar}");
            motorcycle.Start();
        }
    }
}
