using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_4
{
    // Utility class to hold static methods
    public class Utility
    {
        // Static method to calculate the perimeter of a rectangle
        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        // Static method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Static method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

    }

}