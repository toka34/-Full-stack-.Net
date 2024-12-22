using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.problem_15
{
    public class CircleClass
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public CircleClass(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        public override bool Equals(object obj)
        {
            if (obj is CircleClass circle)
            {
                return Radius == circle.Radius && Color == circle.Color;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (Radius, Color).GetHashCode();
        }
    }
}
