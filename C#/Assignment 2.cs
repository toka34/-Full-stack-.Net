using System;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using static System.Formats.Asn1.AsnWriter;

namespace Day_2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            
                // proplem 1 : this code demonstrates a sum operation
                /*1. declare intger variable
                  2. caculate the summetion
                  3. display the result of summing*/

                //int x = 10; // declare x varible as an intger
                //int y = 20; // declare y varible as an intger
                //int sum = x + y; // calculate the summetion
                //Console.WriteLine(sum); // display the output

                /* question 1 : What is the shortcut to comment and uncomment a selected block of code in Visual 
                Studio ?
                For comment : ctrl +"k"+ ctrl + "c"
                For uncomment : ctrl +"k"+ ctrl + "u"*/



                /*problem 2 : int x = "10"; 
                              console.WriteLine(x + y);
                the errors : 1. intger is not defined in double cotation
                             2. the variable y is not declared
                The correction : int x = 10; 
                                 console.WriteLine(x); */

                // question 2 :  Explain the difference between a runtime error and a logical error with examples?
                //* runtime error : 
                //A runtime error occurs during the execution of a program and prevents it from continuing.
                // These errors are often caused by issues like invalid input, memory access violations, or dividing by zero.
            }   // Example : int number = 10;
                //int divisor = 0;
                //int result = number / divisor; // Runtime error: Division by zero
                //* Logic error : 
                // A logical error occurs when a program runs without crashing but produces incorrect or unexpected results due to flaws in the program logic.
                // These errors are harder to detect because the program executes without any visible issues.
                // int length = 5;
                //int width = 10;
                //int area = length + width; // Logical error: Incorrect formula for area
                //Console.WriteLine($"Area: {area}");

        // problem 3 :-

        //string fullName = "toka hagag";        // To store your full name
        //int age = 20;                       // To store your age
        //int monthlySalary = 1000;   // To store your monthly salary (using decimal for currency)
        //bool isStudent = true;              // To indicate if you are a student


        // question 3 :Why is it important to follow naming conventions such as PascalCase in C#?

        // 1. Improves Readability
        // 2. Enhances Consistency
        // 3. Supports Industry Standards
        // 4. Improves Maintainability
        // 5. Reduces Errors

        // problem 4 :-
        //// Create a StringBuilder object (reference type)
        //StringBuilder builder1 = new StringBuilder("Hello");

        //// Create another reference to the same StringBuilder object
        //StringBuilder builder2 = builder1;

        //Console.WriteLine($"Initial Values:");
        //Console.WriteLine($"builder1: {builder1}");
        //Console.WriteLine($"builder2: {builder2}");

        //// Modify the content of the StringBuilder using one reference
        //builder2.Append(", World!");

        //Console.WriteLine($"\nAfter Modification:");
        //Console.WriteLine($"builder1: {builder1}"); // builder1 reflects the change
        //Console.WriteLine($"builder2: {builder2}");

        //// Verify that both references point to the same object
        //Console.WriteLine($"\nAre builder1 and builder2 pointing to the same object? {ReferenceEquals(builder1, builder2)}");

        // question 4

        //Value types store actual data directly and are typically stored on the stack, making them more lightweight and independent.
        //Reference types store references (pointers) to data, which is stored on the heap. They can share data, and modifying the data via one reference affects all references pointing to the same object.


        // problem 5
        //// Declare and initialize the variables
        //int x = 15;
        //int y = 4;

        //// Calculate sum
        //int sum = x + y;

        //// Calculate difference
        //int difference = x - y;

        //// Calculate product
        //int product = x * y;

        //// Calculate division result (quotient)
        //int divisionResult = x / y;

        //// Calculate remainder (modulus)
        //int remainder = x % y;

        //// Display the results
        //Console.WriteLine($"Sum: {sum}");
        //    Console.WriteLine($"Difference: {difference}");
        //    Console.WriteLine($"Product: {product}");
        //    Console.WriteLine($"Division Result: {divisionResult}");
        //    Console.WriteLine($"Remainder: {remainder}");


        // question 5: 
        // the output : 2
        // why : The % operator returns the remainder of the division. Since 2 is smaller than 7, the remainder is 2.


        // problem 6 : 
        //// Ask the user to input a number
        //Console.Write("Enter a number: ");
        //    int number = int.Parse(Console.ReadLine());

        //    // Check if the number is greater than 10 and even
        //    if (number > 10 && number % 2 == 0)
        //    {
        //        Console.WriteLine("The number is both greater than 10 and even.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The number is either not greater than 10 or not even.");
        //    }


        // question 6 :
        //&& is used for logical operations with boolean values and short-circuits for efficiency.
        //& is used for bitwise operations with integer values, comparing individual bits, and does not short-circuit.


        // problem 7 :
        //Console.Write("Enter a double value: ");
        //    double userInput = double.Parse(Console.ReadLine());
        //int explicitCast = (int)userInput;
        //Console.WriteLine($"Explicit Casting (double to int): {explicitCast}");
        //    float floatValue = (float)userInput;
        //double implicitCast = floatValue;
        //Console.WriteLine($"Implicit Casting (float to double): {implicitCast}");

        // question 7 : 

        // Explicit casting is required when converting from double to int because:
        //1. Data loss: The fractional part of the double would be discarded.
        //2. Precision risk: There's a potential for losing important decimal information, and explicit casting makes the programmer aware of this risk.
        //3. C# requires explicit casting to avoid accidental truncation, ensuring that the programmer is consciously making this decision.


        // problem 8 : 

        //        Console.Write("Please enter your age: ");
        //            string ageInput = Console.ReadLine();

        //            // Try to convert the string to an integer using Parse
        //            try
        //            {
        //                int age = int.Parse(ageInput);

        //                // Check if the age is valid (greater than 0)
        //                if (age > 0)
        //                {
        //                    Console.WriteLine($"Your age is {age}.");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("Please enter a valid age greater than 0.");
        //                }
        //            }
        //            catch (FormatException)
        //            {
        //    // Handle invalid input (e.g., non-numeric values)
        //    Console.WriteLine("Invalid input. Please enter a valid number for your age.");
        //}

        // question 8 : 
        // FormatException: Caught when the input is not a valid integer (e.g., letters, special characters).
        // OverflowException: Caught when the integer input exceeds the limits of an int (greater than Int32.MaxValue or less than Int32.MinValue).
        // By using try-catch blocks, you can handle these exceptions gracefully and ensure that the user is prompted with clear error messages when their input is invalid.


        // proplem 9 : 
        //static void Main()
        //{
        //    int x = 5;

        //    // Demonstrating Postfix Increment (x++)
        //    Console.WriteLine("Original value of x: " + x);
        //    int resultPostfix = x++;  // Postfix increment
        //    Console.WriteLine("Value of x after postfix increment: " + x);
        //    Console.WriteLine("Result of postfix increment: " + resultPostfix);

        //    // Resetting x for the next demonstration
        //    x = 5;

        //    // Demonstrating Prefix Increment (++x)
        //    Console.WriteLine("\nOriginal value of x: " + x);
        //    int resultPrefix = ++x;  // Prefix increment
        //    Console.WriteLine("Value of x after prefix increment: " + x);
        //    Console.WriteLine("Result of prefix increment: " + resultPrefix);
        //}

    }   // question 9 : 
        // x= 7
        // y= 12
        // why : ++x will make x = 6
        //       x++ will make x = 7 but after y is calculated


}









