using System;
using day_06_G01;
using Day_09.Problem_1._2;
using Day_09.Problem_10;
using Day_09.Problem_11;
using Day_09.Problem_13;
using Day_09.Problem_14;
using Day_09.problem_15;
using Day_09.Problem_2._2;
using Day_09.Problem_4;

namespace Day_09
{
    #region P:1.1 enum
    //public enum Weekdays
    //{
    //    Monday = 1,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday
    //} 
    #endregion

    #region p:2.1 enum
    //public enum Grades : short
    //{
    //    A, B, C, D, E, F = -1

    //}
    #endregion

    #region Problem 3.1
    //enum Gender : byte
    //{
    //    Male = 1,
    //    Female
    //}
    //class Person
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public Gender Gender { get; set; }
    //    public string Department { get; set; } // New Department property
    //} 
    #endregion

    #region p:7.1 enum
    //public enum Gender : byte
    //{
    //    Male = 1,
    //    Female = 2,
    //} 
    #endregion

    #region p:15.1 struct
    //public struct Circle
    //{
    //    public double Radius { get; set; }
    //    public string Color { get; set; }

    //    public Circle(double radius, string color)
    //    {
    //        Radius = radius;
    //        Color = color;
    //    }

    //    public override bool Equals(object obj)
    //    {
    //        if (obj is Circle circle)
    //        {
    //            return Radius == circle.Radius && Color == circle.Color;
    //        }
    //        return false;
    //    }

    //    public override int GetHashCode()
    //    {
    //        return (Radius, Color).GetHashCode();
    //    }

    //    public static bool operator ==(Circle a, Circle b)
    //    {
    //        return a.Equals(b);
    //    }

    //    public static bool operator !=(Circle a, Circle b)
    //    {
    //        return !a.Equals(b);
    //    }
    //} 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1.1

            //// Print the name and value of each day
            //foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{day} : {(int)day}");
            //} 
            #endregion

            #region Problem 2.1
            //// Print the name and value of each grade
            //foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            //{
            //    Console.WriteLine($"{grade} = {(short)grade}");
            //} 
            #endregion

            #region Problem 3.1
            //// Instantiate two Person objects
            //Person person1 = new Person
            //{
            //    Id = 1,
            //    Name = "Alice",
            //    Gender = Gender.Female,
            //    Department = "Human Resources"
            //};

            //Person person2 = new Person
            //{
            //    Id = 2,
            //    Name = "Bob",
            //    Gender = Gender.Male,
            //    Department = "Engineering"
            //};

            //// Print details of person1
            //Console.WriteLine($"Id: {person1.Id}, Name: {person1.Name}, Gender: {person1.Gender}, Department: {person1.Department}");

            //// Print details of person2
            //Console.WriteLine($"Id: {person2.Id}, Name: {person2.Name}, Gender: {person2.Gender}, Department: {person2.Department}"); 
            #endregion

            #region Problem 4.1
            //// Instantiate the Child class
            //Child child = new Child(60000);

            //// Demonstrate the use of DisplaySalary method
            //child.DisplaySalary(); 
            #endregion

            #region Problem 5.1
            //// Define the dimensions of the rectangle
            //double length = 5.0;
            //double width = 3.0;

            //// Call the static method to calculate the perimeter
            //double perimeter = Utility.CalculatePerimeter(length, width);

            //// Print the result
            //Console.WriteLine($"The perimeter of the rectangle is: {perimeter}"); 
            #endregion

            #region Problem 6.1
            //// Create two complex numbers
            //ComplexNumber c1 = new ComplexNumber { Real = 3, Imag = 2 }; // 3 + 2i
            //ComplexNumber c2 = new ComplexNumber { Real = 1, Imag = 7 }; // 1 + 7i

            //// Demonstrate addition
            //ComplexNumber sum = c1 + c2;
            //Console.WriteLine($"Sum: {sum}");

            //// Demonstrate subtraction
            //ComplexNumber difference = c1 - c2;
            //Console.WriteLine($"Difference: {difference}");

            //// Demonstrate multiplication
            //ComplexNumber product = c1 * c2;
            //Console.WriteLine($"Product: {product}"); 
            #endregion

            #region Problem 7.1
            //// Display the size of the Gender enum
            //Console.WriteLine($"Size of Gender enum (byte): {sizeof(Gender)} bytes");

            //// Display the size of an int
            //Console.WriteLine($"Size of int: {sizeof(int)} bytes");

            //// Optionally, demonstrate the memory usage of an array of enums vs. an array of ints
            //Gender[] genderArray = new Gender[1000];
            //int[] intArray = new int[1000];

            //Console.WriteLine($"Size of Gender array (1000 elements): {genderArray.Length * sizeof(Gender)} bytes");
            //Console.WriteLine($"Size of int array (1000 elements): {intArray.Length * sizeof(int)} bytes"); 
            #endregion

            #region Problem 8.1
            //// Demonstrate temperature conversion
            //double celsius = 25.0;
            //double fahrenheit = 77.0;

            //// Convert Celsius to Fahrenheit
            //double convertedToFahrenheit = Utility.CelsiusToFahrenheit(celsius);
            //Console.WriteLine($"{celsius}°C is {convertedToFahrenheit}°F");

            //// Convert Fahrenheit to Celsius
            //double convertedToCelsius = Utility.FahrenheitToCelsius(fahrenheit);
            //Console.WriteLine($"{fahrenheit}°F is {convertedToCelsius}°C"); 
            #endregion

            #region Problem 9.1
            //Console.WriteLine("Enter a grade (A, B, C, D, E, F):");
            //string input = Console.ReadLine();

            //// Try to parse the input to a Grades enum value
            //if (Enum.TryParse<Grades>(input, true, out Grades grade))
            //{
            //    Console.WriteLine($"Parsed grade: {grade} (Value: {(short)grade})");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid grade entered. Please enter a valid grade (A, B, C, D, E, F).");
            //} 
            #endregion

            #region Problem 10.1

            //// Create an array of Employee objects
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1, "Alice", 5000, 30),
            //new Employee(2, "Bob", 6000, 25),
            //new Employee(3, "Charlie", 7000, 35)
            //};

            //// Create a target employee to search for
            //Employee target = new Employee(2, "Bob", 6000, 25);

            //// Search for the employee in the array
            //Employee? foundEmployee = Helper2.SearchArray(employees, target);

            //// Display the result
            //if (foundEmployee != null)
            //{
            //    Console.WriteLine($"Found: {foundEmployee}");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //} 
            #endregion

            #region Problem 11.1
            //// Demonstrate Max with integers
            //int int1 = 10;
            //int int2 = 20;
            //int maxInt = Helper.Max(int1, int2);
            //Console.WriteLine($"Max of {int1} and {int2} is: {maxInt}");

            //// Demonstrate Max with doubles
            //double double1 = 10.5;
            //double double2 = 20.3;
            //double maxDouble = Helper.Max(double1, double2);
            //Console.WriteLine($"Max of {double1} and {double2} is: {maxDouble}");

            //// Demonstrate Max with strings
            //string str1 = "Ahmed";
            //string str2 = "Mohammed";
            //string maxString = Helper.Max(str1, str2);
            //Console.WriteLine($"Max of \"{str1}\" and \"{str2}\" is: \"{maxString}\""); 
            #endregion

            #region Problem 12.1
            //// Demonstrate ReplaceArray with an integer array
            //int[] intArray = { 1, 2, 3, 4, 2, 5, 2 };
            //Console.WriteLine("Original integer array: " + string.Join(", ", intArray));

            //// Replace all occurrences of 2 with 99
            //Helper2.ReplaceArray(intArray, 2, 99);
            //Console.WriteLine("Modified integer array: " + string.Join(", ", intArray));

            //// Demonstrate ReplaceArray with a string array
            //string[] strArray = { "apple", "banana", "apple", "cherry" };
            //Console.WriteLine("Original string array: " + string.Join(", ", strArray));

            //// Replace all occurrences of "apple" with "orange"
            //Helper2.ReplaceArray(strArray, "apple", "orange");
            //Console.WriteLine("Modified string array: " + string.Join(", ", strArray)); 
            #endregion

            #region Problem 13.1
            //// Create two Rectangle instances
            //Rectangle rect1 = new Rectangle(10.0, 5.0);
            //Rectangle rect2 = new Rectangle(3.0, 7.0);

            //// Display original rectangles
            //Console.WriteLine("Before Swap:");
            //Console.WriteLine($"Rectangle 1: {rect1}");
            //Console.WriteLine($"Rectangle 2: {rect2}");

            //// Swap the rectangles
            //RectangleHelper.Swap(ref rect1, ref rect2);

            //// Display swapped rectangles
            //Console.WriteLine("\nAfter Swap:");
            //Console.WriteLine($"Rectangle 1: {rect1}");
            //Console.WriteLine($"Rectangle 2: {rect2}"); 
            #endregion

            #region Problem 14.1
            //// Create departments
            //Department sales = new Department("Sales");
            //Department engineering = new Department("Engineering");
            //Department hr = new Department("HR");

            //// Create an array of Employee objects
            //Employee[] employees = new Employee[]
            //{
            //new Employee(1, "Alice", 5000, 30, sales),
            //new Employee(2, "Bob", 6000, 25, engineering),
            //new Employee(3, "Charlie", 7000, 35, sales),
            //new Employee(4, "David", 4000, 28, hr)
            //};

            //// Search for employees in the Sales department
            //Employee[] salesEmployees = Helper2.SearchByDepartment(employees, sales);

            //// Display the results
            //Console.WriteLine("Employees in Sales Department:");
            //foreach (var employee in salesEmployees)
            //{
            //    Console.WriteLine(employee);
            //} 
            #endregion

            #region Proplem 15.1
            //// Create instances of Circle struct
            //Circle circle1 = new Circle(5.0, "Red");
            //Circle circle2 = new Circle(5.0, "Red");
            //Circle circle3 = circle1; // Copy of circle1

            //// Compare Circle structs
            //Console.WriteLine("Comparing Circle structs:");
            //Console.WriteLine($"circle1 == circle2: {circle1 == circle2}"); // True
            //Console.WriteLine($"circle1.Equals(circle2): {circle1.Equals(circle2)}"); // True
            //Console.WriteLine($"circle1 == circle3: {circle1 == circle3}"); // True
            //Console.WriteLine($"circle1.Equals(circle3): {circle1.Equals(circle3)}"); // True

            //// Create instances of CircleClass
            //CircleClass circleClass1 = new CircleClass(5.0, "Red");
            //CircleClass circleClass2 = new CircleClass(5.0, "Red");
            //CircleClass circleClass3 = circleClass1; // Reference to circleClass1

            //// Compare Circle classes
            //Console.WriteLine("\nComparing Circle classes:");
            //Console.WriteLine($"circleClass1 == circleClass2: {circleClass1 == circleClass2}"); // False
            //Console.WriteLine($"circleClass1.Equals(circleClass2): {circleClass1.Equals(circleClass2)}"); // True
            //Console.WriteLine($"circleClass1 == circleClass3: {circleClass1 == circleClass3}"); // True
            //Console.WriteLine($"circleClass1.Equals(circleClass3): {circleClass1.Equals(circleClass3)}"); // True 
            #endregion

            #region Problem 1.2
            //    // Test with an array of integers
            //    int[] intArray = { 1, 2, 3, 4, 5 };
            //    int[] reversedIntArray = ArrayHelper.ReverseArray(intArray);
            //    Console.WriteLine("Reversed Integer Array: " + string.Join(", ", reversedIntArray));

            //    // Test with an array of strings
            //    string[] stringArray = { "Apple", "Banana", "Cherry" };
            //    string[] reversedStringArray = ArrayHelper.ReverseArray(stringArray);
            //    Console.WriteLine("Reversed String Array: " + string.Join(", ", reversedStringArray));

            //    // Test with an array of custom objects
            //    Person[] peopleArray = {
            //    new Person("Alice", 30),
            //    new Person("Bob", 25),
            //    new Person("Charlie", 35)
            //};
            //    Person[] reversedPeopleArray = ArrayHelper.ReverseArray(peopleArray);
            //    Console.WriteLine("Reversed People Array: " + string.Join(", ", (object[])reversedPeopleArray)); 
            #endregion

            #region Problem 2.2
            //// Create a stack of integers
            //GenericStack<int> intStack = new GenericStack<int>();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);
            //Console.WriteLine("Top item: " + intStack.Peek()); // Output: 3
            //Console.WriteLine("Popped item: " + intStack.Pop()); // Output: 3
            //Console.WriteLine("Is stack empty? " + intStack.IsEmpty()); // Output: False

            //// Create a stack of strings
            //GenericStack<string> stringStack = new GenericStack<string>();
            //stringStack.Push("Hello");
            //stringStack.Push("World");
            //Console.WriteLine("Top item: " + stringStack.Peek()); // Output: World
            //Console.WriteLine("Popped item: " + stringStack.Pop()); // Output: World
            //Console.WriteLine("Is stack empty? " + stringStack.IsEmpty()); // Output: False 
            #endregion

            #region Problem 3.2
            //    // Test with an array of integers
            //    int[] intArray = { 1, 2, 3, 4, 5 };
            //    Console.WriteLine("Original Integer Array: " + string.Join(", ", intArray));
            //    ArrayHelper.Swap(intArray, 1, 3); // Swap elements at index 1 and 3
            //    Console.WriteLine("After Swap: " + string.Join(", ", intArray));

            //    // Test with an array of strings
            //    string[] stringArray = { "Apple", "Banana", "Cherry" };
            //    Console.WriteLine("Original String Array: " + string.Join(", ", stringArray));
            //    ArrayHelper.Swap(stringArray, 0, 2); // Swap elements at index 0 and 2
            //    Console.WriteLine("After Swap: " + string.Join(", ", stringArray));

            //    // Test with an array of custom objects
            //    Person[] peopleArray = {
            //    new Person("Alice", 30),
            //    new Person("Bob", 25),
            //    new Person("Charlie", 35)
            //};
            //    Console.WriteLine("Original People Array: " + string.Join(", ", (object[])peopleArray));
            //    ArrayHelper.Swap(peopleArray, 0, 1); // Swap elements at index 0 and 1
            //    Console.WriteLine("After Swap: " + string.Join(", ", (object[])peopleArray)); 
            #endregion

            #region Problem 4.2
            //// Test with an array of integers
            //int[] intArray = { 1, 5, 3, 9, 2 };
            //int maxInt = ArrayHelper.FindMaximum(intArray);
            //Console.WriteLine("Maximum Integer: " + maxInt); // Output: 9

            //// Test with an array of doubles
            //double[] doubleArray = { 1.5, 2.3, 3.7, 0.5 };
            //double maxDouble = ArrayHelper.FindMaximum(doubleArray);
            //Console.WriteLine("Maximum Double: " + maxDouble); // Output: 3.7

            //// Test with an array of strings
            //string[] stringArray = { "apple", "banana", "cherry" };
            //string maxString = ArrayHelper.FindMaximum(stringArray);
            //Console.WriteLine("Maximum String: " + maxString); // Output: cherry 
            #endregion
        }
    }
    
}
