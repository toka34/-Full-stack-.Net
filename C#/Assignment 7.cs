using System;

namespace Day_07
{
    /* //problem 1
    class Car
    {
        public int? Id { get; set; }
        public string Brand { get; set; }
        public decimal? Price { get; set; }

        // Default constructor
        public Car()
        {
            Id = null;
            Brand = null;
            Price = null;
        }

        // Constructor with one parameter (Id)
        public Car(int id)
        {
            Id = id;
            Brand = null;
            Price = null;
        }

        // Constructor with two parameters (Id, Brand)
        public Car(int id, string brand)
        {
            Id = id;
            Brand = brand;
            Price = null;
        }

        // Constructor with all three parameters (Id, Brand, Price)
        public Car(int id, string brand, decimal price)
        {
            Id = id;
            Brand = brand;
            Price = price;
        }

        public override string ToString()
        {
            return $"Car(Id: {Id}, Brand: {Brand}, Price: {Price})";
        }
    }*/

    /* //problem 2
    class Calculator
    {
        // Method to add two integers
        public int Sum(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two doubles
        public double Sum(double a, double b)
        {
            return a + b;
        }
    }*/

    /* //problem 3
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent constructor called.");
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Child constructor called.");
        }
    }*/

    /* //problem 4
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual int Product()
        {
            return X * Y;
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override int Product()
        {
            return X * Y * Z;
        }
    }*/

    /* //problem 5
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }*/

    /*//problem 6

    interface IShape
    {
        double Area { get; }
        void Draw();
    }

    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void Draw()
        {
            Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
        }
    }*/

    /* //problem 7

    public abstract class Shape
    {
        // Default implementation of PrintDetails
        public virtual void PrintDetails()
        {
            Console.WriteLine("This is a shape.");
        }

        // Abstract method that derived classes must implement
        public abstract double Area();
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Implementing the abstract method
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        // Optionally override PrintDetails if you want specific details for Circle
        public override void PrintDetails()
        {
            base.PrintDetails(); // Call the base implementation
            Console.WriteLine($"Circle with radius: {radius}, Area: {Area()}");
        }
    }*/

    /* //problem 8

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        private string model;

        public Car(string model)
        {
            this.model = model;
        }

        public void Move()
        {
            Console.WriteLine($"{model} is moving.");
        }
    }*/

    /* //problem 9

    public interface IReadable
    {
        string Read();
    }

    public interface IWritable
    {
        void Write(string content);
    }

    public class File : IReadable, IWritable
    {
        private string content;

        public void Write(string content)
        {
            this.content = content;
            Console.WriteLine("Content written to file.");
        }

        public string Read()
        {
            return content ?? "No content available.";
        }
    }*/

    /* //problem 10
    public abstract class Shape
    {
        // Virtual method that can be overridden
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        // Abstract method that must be implemented by derived classes
        public abstract double CalculateArea();
    }

    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Override the Draw method
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        // Implement the CalculateArea method
        public override double CalculateArea()
        {
            return width * height;
        }
    }*/


    internal class Program
    {
        static void Main(string[] args)
        {
            /* // problem 1
            // 1. Default constructor
            Car car1 = new Car();
            Console.WriteLine(car1); // Output: Car(Id: , Brand: , Price: )

            // 2. Constructor with one parameter (Id)
            Car car2 = new Car(1);
            Console.WriteLine(car2); // Output: Car(Id: 1, Brand: , Price: )

            // 3. Constructor with two parameters (Id, Brand)
            Car car3 = new Car(2, "Toyota");
            Console.WriteLine(car3); // Output: Car(Id: 2, Brand: Toyota, Price: )

            // 4. Constructor with all three parameters (Id, Brand, Price)
            Car car4 = new Car(3, "Honda", 20000);
            Console.WriteLine(car4); // Output: Car(Id: 3, Brand: Honda, Price: 20000)
            */

            /* //problem 2

            Calculator calculator = new Calculator();

            // Test adding two integers
            int result1 = calculator.Sum(10, 20);
            Console.WriteLine($"Sum of two integers: {result1}"); // Output: 30

            // Test adding three integers
            int result2 = calculator.Sum(10, 20, 30);
            Console.WriteLine($"Sum of three integers: {result2}"); // Output: 60

            // Test adding two doubles
            double result3 = calculator.Sum(10.5, 20.5);
            Console.WriteLine($"Sum of two doubles: {result3}"); // Output: 31.0
            */

            /*//problem 3
            Child child = new Child(10, 20, 30);
            */

            /* //problem 4
             
            Child child = new Child(2, 3, 4);

            Console.WriteLine("Product: " + child.Product()); // Output: 24

            Parent parent = child;
            Console.WriteLine("Product: " + parent.Product()); // Output: 24
            */

            /* //problem 5
            Parent parent = new Parent(10, 20);
            Child child = new Child(30, 40, 50);

            Console.WriteLine(parent); // Output: (10, 20)
            Console.WriteLine(child);  // Output: (30, 40, 50)
            */

            /* //problem 6

            Rectangle rect = new Rectangle(5, 10);
            Console.WriteLine($"Area of the rectangle: {rect.Area}");
            rect.Draw();
            */

            /* //problem 7    
        
            Circle circle = new Circle(5);
            circle.PrintDetails();*/

            /* //problem 8

            // Create an instance of Car
            Car myCar = new Car("Toyota");

            // Use an IMovable reference to access the Car object
            IMovable movableCar = myCar;

            // Call the Move method
            movableCar.Move(); // Output: Toyota is moving.
            */

            /* //problem 9

            // Create an instance of File
            File myFile = new File();

            // Write content to the file
            myFile.Write("Hello, World!");

            // Read content from the file
            string fileContent = myFile.Read();
            Console.WriteLine($"File content: {fileContent}"); // Output: File content: Hello, World!
            */

            /* //problem 10

            // Create an instance of Rectangle
        Rectangle myRectangle = new Rectangle(5, 10);

            // Call the Draw method
            myRectangle.Draw(); // Output: Drawing Rectangle

            // Calculate and display the area
            double area = myRectangle.CalculateArea();
            Console.WriteLine($"Area of Rectangle: {area}"); // Output: Area of Rectangle: 50
            */
        }
    }
}

