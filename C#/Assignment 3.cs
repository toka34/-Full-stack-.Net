using System;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Day_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // problem 1 : 

            //Console.WriteLine("Enter a string to convert to an integer:");

            //string input = Console.ReadLine();

            //// Using int.Parse
            //try
            //{
            //    int result1 = int.Parse(input);
            //    Console.WriteLine($"int.Parse: {result1}");
            //}
            //catch
            //{
            //    Console.WriteLine("int.Parse: Error");
            //}

            //// Using Convert.ToInt32
            //try
            //{
            //    int result2 = Convert.ToInt32(input);
            //    Console.WriteLine($"Convert.ToInt32: {result2}");
            //}
            //catch
            //{
            //    Console.WriteLine("Convert.ToInt32: Error");
            //}

            //Question 1 : Use int.Parse if you expect a valid number and want to enforce strict validation.
            //             Use Convert.ToInt32 if you want to gracefully handle null inputs by defaulting to 0.


            //problem 2 :-

            //Console.WriteLine("Enter a number:");

            //string input = Console.ReadLine();

            //// Use int.TryParse to validate the input
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine($"You entered: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid number.");
            //}

            // question 2 : TryParse is generally recommended over Parse in user-facing applications because it is more robust and user-friendly when handling potentially invalid inputs.


            // problem 3 : 

            //object obj;

            //// Assign an int value and print its hash code
            //obj = 42;
            //Console.WriteLine($"Type: {obj.GetType()}, HashCode: {obj.GetHashCode()}");

            //// Assign a string value and print its hash code
            //obj = "Hello, World!";
            //Console.WriteLine($"Type: {obj.GetType()}, HashCode: {obj.GetHashCode()}");

            //// Assign a double value and print its hash code
            //obj = 3.14;
            //Console.WriteLine($"Type: {obj.GetType()}, HashCode: {obj.GetHashCode()}");

            // question 3 :The primary purpose of the GetHashCode() method in .NET is to generate a numerical hash code that represents the state of an object for efficient lookups and comparisons in hash-based collections like Dictionary<TKey, TValue>, HashSet<T>, or Hashtable.


            // problem 4 :-

            //string str1 = "Hello";
            //Console.WriteLine($"Initial Value (str1): {str1}");

            //string str2 = str1;

            //str1 = "World";

            //Console.WriteLine($"Value after modification (str2): {str2}");
            //Console.WriteLine($"Value after modification (str1): {str1}");


            // question 4 : In .NET, reference equality checks if two variables point to the same object in memory. This is important for reference types like objects, arrays, and strings, as it helps determine whether two references refer to the same instance, rather than just having the same content or value.


            // problem 5 :-
            //string message = "Hello";

            //Console.WriteLine($"Before modification - GetHashCode: {message.GetHashCode()}");

            //message += " Hi Willy";

            //Console.WriteLine($"After modification - GetHashCode: {message.GetHashCode()}");

            // question 5 : In C#, strings are immutable because their values cannot be changed once they are created. This design decision has several important advantages, both in terms of performance and safety.

            // problem 6 :-

            //StringBuilder sb = new StringBuilder("Hi Willy");

            //Console.WriteLine($"Before modification - GetHashCode: {sb.GetHashCode()}");

            //sb.Append(" How are you?");

            //Console.WriteLine($"After modification - GetHashCode: {sb.GetHashCode()}");


            // question 6 : StringBuilder in C# is designed to address the inefficiencies of string concatenation in scenarios where strings are modified repeatedly, such as in loops or when building large strings.


            // question 7 : StringBuilder is faster for large-scale string modifications compared to regular string concatenation in C# because it is optimized for scenarios where strings are repeatedly modified.


            // problem 8 : 

            //Console.Write("Enter the first integer: ");
            //int input1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the second integer: ");
            //int input2 = Convert.ToInt32(Console.ReadLine());

            //int sum = input1 + input2;

            //Console.WriteLine("Sum using concatenation: " + "Sum is " + input1 + " + " + input2 + " = " + sum);

            //Console.WriteLine(string.Format("Sum using composite formatting: Sum is {0} + {1} = {2}", input1, input2, sum));

            //Console.WriteLine($"Sum using string interpolation: Sum is {input1} + {input2} = {sum}");


            // question 8 : String interpolation is the most widely used and recommended string formatting method in C# because it's readable, concise, and efficient, making it the preferred choice for most scenarios.
            //              It allows developers to write clean, understandable, and less error-prone code while still providing the flexibility to embed expressions directly within the string.


            //problem 9 :

            //StringBuilder sb = new StringBuilder("Hello, World!");

            //sb.Append(" How are you?");
            //Console.WriteLine("After Append: " + sb.ToString());

            //sb.Replace("World", "Universe");
            //Console.WriteLine("After Replace: " + sb.ToString());

            //sb.Insert(7, "Beautiful ");
            //Console.WriteLine("After Insert: " + sb.ToString());

            //sb.Remove(7, 10); // Removes 10 characters starting at position 7
            //Console.WriteLine("After Remove: " + sb.ToString());


            //question 9 : StringBuilder is designed for handling frequent string modifications efficiently by using a mutable buffer instead of creating new string objects with each modification.
            //             Unlike strings, which are immutable in C#, meaning each change creates a new object, StringBuilder allows you to modify the content of the string directly without reallocating memory every time.

        }
    }
}
