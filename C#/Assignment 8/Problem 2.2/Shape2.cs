using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class Shape2 : IComparable<Shape2>
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Shape2(string name, double area)
        {
            Name = name;
            Area = area;
        }

        public int CompareTo(Shape2 other)
        {
            if (other == null) return 1; // If other is null, this instance is greater
            return Area.CompareTo(other.Area); // Compare areas
        }

        public override string ToString()
        {
            return $"{Name}: Area = {Area}";
        }
    }

    public class Square2 : Shape2
    {
        public Square2(double sideLength) : base("Square", sideLength * sideLength) { }
    }

    public class Circle2 : Shape2
    {
        public Circle2(double radius) : base("Circle", Math.PI * radius * radius) { }
    }

    public class Rectangle2 : Shape2
    {
        public Rectangle2(double width, double height) : base("Rectangle", width * height) { }
    }

}
