using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public abstract class Shape
    {
        // Abstract method
        public abstract double GetArea();

        // Non-abstract method
        public void Display()
        {
            Console.WriteLine($"The area of the shape is: {GetArea()}");
        }
    }
    // Rectangle class inheriting from Shape
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public override double GetArea()
        {
            return _width * _height;
        }
    }

    // Circle class inheriting from Shape
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    // Rectangle class implementing IShape
    public class RectangleInterface : IShape
    {
        private double _width;
        private double _height;

        public RectangleInterface(double width, double height)
        {
            _width = width;
            _height = height;
        }

        public double GetArea()
        {
            return _width * _height;
        }

        public void Display()
        {
            Console.WriteLine($"The area of the rectangle is: {GetArea()}");
        }
    }

    // Circle class implementing IShape
    public class CircleInterface : IShape
    {
        private double _radius;

        public CircleInterface(double radius)
        {
            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public void Display()
        {
            Console.WriteLine($"The area of the circle is: {GetArea()}");
        }
    }
}

