using System;

namespace Day_06
{
    /* //problem 1
    struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }*/

    /* //problem 2
    public class TypeA
    {

        private int F; 
        internal int G; 
        public int H; 

        public TypeA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }

        public int GetF() => F; 
    }
    */

    /* // problem 3
    struct Employee
    {
        // Private attributes
        private int EmpId;
        private string Name;
        private decimal Salary;

        // Constructor to initialize attributes
        public Employee(int empId, string name, decimal salary)
        {
            EmpId = empId;
            Name = name;
            Salary = salary;
        }

        // Public methods to access and modify the private Name attribute
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Invalid name. Name cannot be empty.");
            }
        }

        // Properties to access private attributes
        public int EmployeeId
        {
            get { return EmpId; }
        }

        public decimal EmployeeSalary
        {
            get { return Salary; }
            set
            {
                if (value > 0)
                {
                    Salary = value;
                }
                else
                {
                    Console.WriteLine("Invalid salary. Salary must be positive.");
                }
            }
        }
    }
    */

    /* /problem 4

    struct Point
    {
        public int X { get; }
        public int Y { get; }

        // Constructor to initialize X to a specific value and Y to 0
        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        // Constructor to initialize X and Y to specific values
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Method to display point details
        public void Display()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }
        
    }
    */

    /*//prblem 5

    struct Point
    {
        public int X { get; }
        public int Y { get; }

        // Constructor to initialize X to a specific value and Y to 0
        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        // Constructor to initialize X and Y to specific values
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        // Override ToString() to provide custom formatting
        public override string ToString()
        {
            return $"Point Coordinates: X = {X}, Y = {Y}";
        }
    }
    */

    /* //porblem 6

    struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    */

    internal class Program
    {
        /* //problem 6
        static void ModifyPoint(Point p)
        {
            p.X = 100;
            p.Y = 200;
            Console.WriteLine($"Inside ModifyPoint: {p.X}, {p.Y}");
        }

        static void ModifyEmployee(Employee e)
        {
            e.Name = "Modified Name";
            e.Age = 99;
            Console.WriteLine($"Inside ModifyEmployee: {e.Name}, {e.Age}");
        }
        */

        static void Main(string[] args)
        {
            /* //problem 1
            Point defaultPoint = new Point(); 
            Console.WriteLine("Default Point: " + defaultPoint);

            Point parameterizedPoint = new Point(3, 7);
            Console.WriteLine("Parameterized Point: " + parameterizedPoint);
            */

            /* //problem 2
            TypeA obj = new TypeA(10, 20, 30);

            // Access private attribute through a public method
            Console.WriteLine("Private F: " + obj.GetF());

            // Access internal attribute (works because we are in the same assembly)
            Console.WriteLine("Internal G: " + obj.G);

            // Access public attribute
            Console.WriteLine("Public H: " + obj.H);
            */

            /* // problem 3
            Employee emp = new Employee(1, "John Doe", 50000);

            // Access and modify attributes using methods and properties
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"ID: {emp.EmployeeId}");
            Console.WriteLine($"Name: {emp.GetName()}");
            Console.WriteLine($"Salary: {emp.EmployeeSalary}");

            // Update name using the SetName method
            emp.SetName("Jane Smith");
            Console.WriteLine("\nAfter updating name:");
            Console.WriteLine($"Name: {emp.GetName()}");

            // Update salary using the property
            emp.EmployeeSalary = 60000;
            Console.WriteLine("\nAfter updating salary:");
            Console.WriteLine($"Salary: {emp.EmployeeSalary}");

            // Try setting an invalid name and salary
            emp.SetName(""); // Invalid name
            emp.EmployeeSalary = -10000;
            */

            /* //problem 4
            // Create a Point using the first constructor
            Point point1 = new Point(5);
            Console.WriteLine("Using constructor with X initialized, Y defaulted to 0:");
            point1.Display();

            // Create a Point using the second constructor
            Point point2 = new Point(3, 7);
            Console.WriteLine("\nUsing constructor with X and Y initialized:");
            point2.Display();
            */

            /* //problem 5
            
            // Create and print multiple Point objects
            Point point1 = new Point(5);
            Point point2 = new Point(3, 7);
            Point point3 = new Point(0, 0);

            Console.WriteLine("Testing custom ToString() method:");
            Console.WriteLine(point1); // Uses the custom ToString() method
            Console.WriteLine(point2); // Uses the custom ToString() method
            Console.WriteLine(point3); // Uses the custom ToString() method
            */

            /* //problem 6

            // Struct (Value Type)
            Point point = new Point(10, 20);
            Console.WriteLine($"Before ModifyPoint: {point.X}, {point.Y}");
            ModifyPoint(point);
            Console.WriteLine($"After ModifyPoint: {point.X}, {point.Y}");

            Console.WriteLine();

            // Class (Reference Type)
            Employee employee = new Employee("John Doe", 30);
            Console.WriteLine($"Before ModifyEmployee: {employee.Name}, {employee.Age}");
            ModifyEmployee(employee);
            Console.WriteLine($"After ModifyEmployee: {employee.Name}, {employee.Age}");
            */
        }
    }
}
