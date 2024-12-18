using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace Day_08
{
    internal class Program
    {
        #region Problem 7.1
        //public class DefaultLogger : ILogger
        //{
        //} 
        #endregion

        #region Problem 1.2
        //static void PrintTenShapes(IShapeSeries series)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        series.GetNextArea();
        //        Console.WriteLine(series.CurrentShapeArea);
        //    }
        //} 
        #endregion

        #region Problem 4.2
        //public static void SelectionSort(int[] numbers)
        //{
        //    int n = numbers.Length;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        int minIndex = i;
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (numbers[j] < numbers[minIndex])
        //            {
        //                minIndex = j;
        //            }
        //        }

        //        if (minIndex != i)
        //        {
        //            int temp = numbers[i];
        //            numbers[i] = numbers[minIndex];
        //            numbers[minIndex] = temp;
        //        }
        //    }
        //} 
        #endregion
        static void Main(string[] args)
        {
            #region Problem 1.1
            //IVehicle myCar = new car1();
            //IVehicle myBike = new Bike();

            //// Start and stop the car engine
            //myCar.StartEngine();
            //myCar.StopEngine();

            //// Start and stop the bike engine
            //myBike.StartEngine();
            //myBike.StopEngine();
            #endregion

            #region Problem 2.1
            //// Using Abstract Class
            //Shape rectangle = new Rectangle(5, 10);
            //rectangle.Display();

            //Shape circle = new Circle(7);
            //circle.Display();

            //// Using Interface
            //IShape rectangleInterface = new RectangleInterface(5, 10);
            //rectangleInterface.Display();

            //IShape circleInterface = new CircleInterface(7);
            //circleInterface.Display(); 
            #endregion

            #region Problem 3.1

            //// Create an array of Product objects
            //Product[] products = new Product[]
            //{
            //    new Product(1, "Laptop", 999.99m),
            //    new Product(2, "Smartphone", 499.99m),
            //    new Product(3, "Tablet", 299.99m),
            //    new Product(4, "Monitor", 199.99m),
            //    new Product(5, "Keyboard", 49.99m)
            //};

            //// Sort the array of products by price
            //Array.Sort(products);

            //// Display the sorted products
            //Console.WriteLine("Products sorted by price:");
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //} 
            #endregion

            #region Problem 4.1

            //// Create a Student object
            //Student originalStudent = new Student(1, "Alice", 90.5);
            //Console.WriteLine("Original Student:");
            //Console.WriteLine(originalStudent);

            //// Create a shallow copy (using assignment)
            //Student shallowCopyStudent = originalStudent;
            //Console.WriteLine("\nShallow Copy Student:");
            //Console.WriteLine(shallowCopyStudent);

            //// Modify the shallow copy
            //shallowCopyStudent.Name = "Bob";
            //shallowCopyStudent.Grade = 85.0;

            //Console.WriteLine("\nAfter modifying the shallow copy:");
            //Console.WriteLine("Original Student:");
            //Console.WriteLine(originalStudent);
            //Console.WriteLine("Shallow Copy Student:");
            //Console.WriteLine(shallowCopyStudent);

            //// Create a deep copy using the copy constructor
            //Student deepCopyStudent = new Student(originalStudent);
            //Console.WriteLine("\nDeep Copy Student:");
            //Console.WriteLine(deepCopyStudent);

            //// Modify the deep copy
            //deepCopyStudent.Name = "Charlie";
            //deepCopyStudent.Grade = 95.0;

            //Console.WriteLine("\nAfter modifying the deep copy:");
            //Console.WriteLine("Original Student:");
            //Console.WriteLine(originalStudent);
            //Console.WriteLine("Deep Copy Student:");
            //Console.WriteLine(deepCopyStudent); 
            #endregion

            #region Problem 5.1
            //Robot robot = new Robot();

            //// Call the Robot's own Walk method
            //robot.Walk(); // Calls the Robot's own method
            //robot.Charge();

            //// Call the IWalkable Walk method using an interface reference
            //IWalkable walkableRobot = robot;
            //walkableRobot.Walk(); // Calls the explicit interface implementation 
            #endregion

            #region Problem 6.1
            //// Create an Account instance
            //Account account = new Account(1, "John Doe", 1000.00m);

            //// Display account details
            //Console.WriteLine($"Account ID: {account.AccountId}");
            //Console.WriteLine($"Account Holder: {account.AccountHolder}");
            //Console.WriteLine($"Initial Balance: {account.Balance:C}");

            //// Demonstrate deposit
            //account.Deposit(500.00m);

            //// Demonstrate withdrawal
            //account.Withdraw(200.00m);

            //// Attempt to withdraw more than the balance
            //account.Withdraw(1500.00m); 
            #endregion

            #region Problem 7.1
            //// Create an instance of ConsoleLogger
            //ILogger logger = new ConsoleLogger();

            //// Call the overridden Log method
            //logger.Log();

            //// If we want to call the default implementation, we can do so by creating an instance of a class that implements ILogger
            //ILogger defaultLogger = new DefaultLogger();
            //defaultLogger.Log(); 
            #endregion

            #region Problem 8.1

            //// Using the default constructor
            //Book defaultBook = new Book();
            //Console.WriteLine("Default Book:");
            //Console.WriteLine(defaultBook);

            //// Using the constructor that takes only Title
            //Book titleOnlyBook = new Book("The Great Gatsby");
            //Console.WriteLine("\nBook with Title Only:");
            //Console.WriteLine(titleOnlyBook);

            //// Using the constructor that takes both Title and Author
            //Book fullBook = new Book("1984", "George Orwell");
            //Console.WriteLine("\nBook with Title and Author:");
            //Console.WriteLine(fullBook); 
            #endregion

            #region Problem 1.2
            //IShapeSeries squareSeries = new SquareSeries();
            //IShapeSeries circleSeries = new CircleSeries();

            //Console.WriteLine("First 10 Areas of Square Series:");
            //PrintTenShapes(squareSeries);

            //Console.WriteLine("\nFirst 10 Areas of Circle Series:");
            //PrintTenShapes(circleSeries); 
            #endregion

            #region Problem 2.2
            //// Create a list of shapes
            //List<Shape2> shapes = new List<Shape2>
            //{
            //    new Square2(4),        // Area = 16
            //    new Circle2(3),        // Area ≈ 28.27
            //    new Rectangle2(2, 5),  // Area = 10
            //    new Square2(2),        // Area = 4
            //    new Circle2(1),        // Area ≈ 3.14
            //    new Rectangle2(3, 3)   // Area = 9
            //};

            //// Sort shapes by area
            //shapes.Sort();

            //// Display sorted shapes
            //Console.WriteLine("Shapes sorted by area in ascending order:");
            //foreach (var shape in shapes)
            //{
            //    Console.WriteLine(shape);
            //} 
            #endregion

            #region Problem 3.2
            //// Create instances of Triangle and Rectangle
            //GeometricShape triangle = new GeoTriangle(10, 5); // base = 10, height = 5
            //GeometricShape rectangle = new GeoRectangle(4, 6); // width = 4, height = 6

            //// Display the area and perimeter of the triangle
            //Console.WriteLine("Triangle:");
            //Console.WriteLine($"Area: {triangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter: {triangle.Perimeter}");

            //// Display the area and perimeter of the rectangle
            //Console.WriteLine("\nRectangle:");
            //Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter: {rectangle.Perimeter}"); 
            #endregion

            #region Problem 4.2
            //// Create instances of Triangle and Rectangle
            //GeometricShape triangle = new GeoTriangle(10, 5); // base = 10, height = 5
            //GeometricShape rectangle = new GeoRectangle(4, 6); // width = 4, height = 6

            //// Store areas in an array
            //int[] areas = new int[]
            //{
            //    (int)triangle.CalculateArea(),
            //    (int)rectangle.CalculateArea()
            //};

            //// Display areas before sorting
            //Console.WriteLine("Areas before sorting:");
            //foreach (var area in areas)
            //{
            //    Console.WriteLine(area);
            //}

            //// Sort the areas using SelectionSort
            //SelectionSort(areas);

            //// Display areas after sorting
            //Console.WriteLine("\nAreas after sorting:");
            //foreach (var area in areas)
            //{
            //    Console.WriteLine(area);
            //} 
            #endregion

            #region Problem 5.2

            //// Create shapes using the ShapeFactory
            //GeometricShape rectangle = ShapeFactory.CreateShape("rectangle", 4, 6);
            //GeometricShape triangle = ShapeFactory.CreateShape("triangle", 10, 5);

            //// Display the area and perimeter of the rectangle
            //Console.WriteLine("Rectangle:");
            //Console.WriteLine($"Area: {rectangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter: {rectangle.Perimeter}");

            //// Display the area and perimeter of the triangle
            //Console.WriteLine("\nTriangle:");
            //Console.WriteLine($"Area: {triangle.CalculateArea()}");
            //Console.WriteLine($"Perimeter: {triangle.Perimeter}"); 
            #endregion
        }
    }
}
