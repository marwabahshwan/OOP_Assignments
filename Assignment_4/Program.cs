using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarwaSaeed_Assignment4
{
    public class Shape
    {
        public virtual double CalculateArea()
        {
            return 0;
        }
    }
    public class Circle : Shape
    {
        public double Radius {  get; set; }
        public override double CalculateArea()
        {
              return 3.14 * Radius * Radius;
        }
    }
    public class Rectangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>
            {
                new Circle {Radius  = 6},
                new Rectangle {Width = 5, Height = 3},
            };
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.GetType());
                Console.WriteLine("The Area:"+shape.CalculateArea());
            }
        }
    }
}

