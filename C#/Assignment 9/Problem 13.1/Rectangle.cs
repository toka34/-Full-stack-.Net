using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_13
{
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override string ToString()
        {
            return $"Rectangle [Length: {Length}, Width: {Width}]";
        }
    }
}
