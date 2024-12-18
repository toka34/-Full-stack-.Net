using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public abstract class GeometricShape
    {
        public double Dimension1 { get; set; }
        public double Dimension2 { get; set; }

        protected GeometricShape(double dimension1, double dimension2)
        {
            Dimension1 = dimension1;
            Dimension2 = dimension2;
        }

        public abstract double CalculateArea();
        public abstract double Perimeter { get; }
    }

    public class GeoTriangle : GeometricShape
    {
        public GeoTriangle(double baseLength, double height) : base(baseLength, height) { }

        public override double CalculateArea()
        {
            return 0.5 * Dimension1 * Dimension2; // Area = 0.5 * base * height
        }

        public override double Perimeter
        {
            get
            {
                // For simplicity, assuming an isosceles triangle
                double sideLength = Math.Sqrt(Math.Pow(Dimension1 / 2, 2) + Math.Pow(Dimension2, 2));
                return Dimension1 + 2 * sideLength; // Perimeter = base + 2 * side
            }
        }
    }

    public class GeoRectangle : GeometricShape
    {
        public GeoRectangle(double width, double height) : base(width, height) { }

        public override double CalculateArea()
        {
            return Dimension1 * Dimension2; // Area = width * height
        }

        public override double Perimeter
        {
            get
            {
                return 2 * (Dimension1 + Dimension2); // Perimeter = 2 * (width + height)
            }
        }
    }

    public static class ShapeFactory
    {
        public static GeometricShape CreateShape(string shapeType, double dim1, double dim2)
        {
            switch (shapeType.ToLower())
            {
                case "rectangle":
                    return new GeoRectangle(dim1, dim2);
                case "triangle":
                    return new GeoTriangle(dim1, dim2);
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }
}