using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_08
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Grade { get; set; }

        // Default constructor
        public Student(int id, string name, double grade)
        {
            Id = id;
            Name = name;
            Grade = grade;
        }

        // Copy constructor for deep copy
        public Student(Student other)
        {
            Id = other.Id;
            Name = string.Copy(other.Name); // Create a deep copy of the string
            Grade = other.Grade;
        }

        // Override ToString for easy display
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Grade: {Grade:F2}";
        }
    }
}
