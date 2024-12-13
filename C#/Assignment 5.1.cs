using System;

namespace day_5
{
   /* problem 2
    * class Demo
    {
        public void TestDefensiveCode()
        {
            int x, y;

            // Loop until a valid positive integer for X is provided
            do
            {
                Console.Write("Enter a positive integer for X: ");
                if (int.TryParse(Console.ReadLine(), out x) && x > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. X must be a positive integer.");
            } while (true);

            // Loop until a valid positive integer greater than 1 for Y is provided
            do
            {
                Console.Write("Enter a positive integer for Y (greater than 1): ");
                if (int.TryParse(Console.ReadLine(), out y) && y > 1)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Y must be a positive integer greater than 1.");
            } while (true);

            Console.WriteLine($"You entered X = {x} and Y = {y}.");
        }
    }*/

    internal class Program
    {
        /* //problem 9
        static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }*/

        /* //problem 10

        static void PrintStringMultipleTimes(string message, int times = 5)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(message);
            }
        }*/

        /* //problem 13

        static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }*/

        static void Main(string[] args)
        {
            /* //Problem 1
            
            try
            {
                Console.Write("Enter the first integer: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter valid integers.");
            }
            finally
            {
                Console.WriteLine("Operation complete.");
            }
            */

            /* //Problem 2
             
            Demo demo = new Demo();
            demo.TestDefensiveCode();
            */

            /* //Problem 3


            int? nullableInt = null;

            // Use the null-coalescing operator (??) to assign a default value if null
            int assignedValue = nullableInt ?? 10;

            Console.WriteLine($"Nullable integer before assignment: {nullableInt}");
            Console.WriteLine($"Value assigned using ?? operator: {assignedValue}");

            // Demonstrate HasValue and Value properties
            nullableInt = 42; // Assign a value to the nullable integer

            Console.WriteLine("\nAfter assigning a value:");
            Console.WriteLine($"HasValue: {nullableInt.HasValue}"); // Checks if the nullableInt has a value
            Console.WriteLine($"Value: {nullableInt.Value}");       // Retrieves the actual value (throws an exception if null)

            nullableInt = null; // Reset nullable integer to null

            Console.WriteLine("\nAfter resetting to null:");
            Console.WriteLine($"HasValue: {nullableInt.HasValue}");
            Console.WriteLine("Trying to access Value when null:");

            try
            {
                Console.WriteLine($"Value: {nullableInt.Value}"); // Throws InvalidOperationException
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            */

            /* //Problem 4
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine("Attempting to access an out-of-bounds index...");
                // Attempt to access an out-of-bounds index
                int value = numbers[10];
                Console.WriteLine($"Value at index 10: {value}");
            }
            catch (IndexOutOfRangeException ex)
            {
                // Handle the exception
                Console.WriteLine("Error: Tried to access an index that is out of bounds.");
                Console.WriteLine($"Exception Message: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program execution complete.");
            }*/

            /* //Problem 5
             * 
            int[,] array = new int[3, 3];

            // Prompt the user to provide values
            Console.WriteLine("Enter values for a 3x3 array:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Calculate and display the sum of elements in each row
            Console.WriteLine("\nSum of each row:");
            for (int i = 0; i < 3; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < 3; j++)
                {
                    rowSum += array[i, j];
                }
                Console.WriteLine($"Row {i + 1}: {rowSum}");
            }

            // Calculate and display the sum of elements in each column
            Console.WriteLine("\nSum of each column:");
            for (int j = 0; j < 3; j++)
            {
                int colSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    colSum += array[i, j];
                }
                Console.WriteLine($"Column {j + 1}: {colSum}");
            }
            */

            /* //Problem 6
             
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[2]; // First row has 2 elements
            jaggedArray[1] = new int[3]; // Second row has 3 elements
            jaggedArray[2] = new int[4]; // Third row has 4 elements

            // Populate the jagged array with user input
            Console.WriteLine("Enter values for the jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Row {i + 1}:");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"Element [{i + 1},{j + 1}]: ");
                    jaggedArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Print all values row by row
            Console.WriteLine("\nValues in the jagged array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.Write($"Row {i + 1}: ");
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            */

            /* //Problem 7
             
            string? userInput = null;

            Console.Write("Do you want to enter a value? (yes/no): ");
            string response = Console.ReadLine()!; // Using null-forgiveness operator to suppress warnings for null-check

            if (response.Equals("yes", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter your value: ");
                userInput = Console.ReadLine();
            }

            // Display the value of userInput
            if (userInput != null)
            {
                Console.WriteLine($"You entered: {userInput}");
            }
            else
            {
                Console.WriteLine("No value was entered.");
            }

            // Using the null-forgiveness operator to suppress warnings
            Console.WriteLine("Using the null-forgiveness operator to suppress warnings:");
            Console.WriteLine($"Uppercase value: {userInput!.ToUpper()}");
            */

            /* //Problem 8
            int valueType = 42; // Value type
            object boxedObject = valueType; // Boxing: assigning value type to an object
            Console.WriteLine("Boxing:");
            Console.WriteLine($"Value type: {valueType}");
            Console.WriteLine($"Boxed object: {boxedObject}");

            // Demonstrate Unboxing
            try
            {
                Console.WriteLine("\nUnboxing:");
                int unboxedValue = (int)boxedObject; // Unboxing: converting object back to value type
                Console.WriteLine($"Unboxed value: {unboxedValue}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Error during unboxing: {ex.Message}");
            }

            // Attempt Invalid Unboxing
            try
            {
                Console.WriteLine("\nAttempting invalid unboxing:");
                double invalidUnbox = (double)boxedObject; // This will throw an InvalidCastException
                Console.WriteLine($"Invalid unbox result: {invalidUnbox}");
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine($"Caught an InvalidCastException: {ex.Message}");
            }
            */

            /* //problem 9

                Console.Write("Enter the first integer: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second integer: ");
                int num2 = int.Parse(Console.ReadLine());

                // Declare variables to hold results
                int resultSum, resultProduct;

                // Call the method
                SumAndMultiply(num1, num2, out resultSum, out resultProduct);

                // Print the results
                Console.WriteLine($"\nResults:");
                Console.WriteLine($"Sum: {resultSum}");
                Console.WriteLine($"Product: {resultProduct}");
           */

            /* //problem 10

            Console.WriteLine("Calling with default times:");
            PrintStringMultipleTimes("Hello");

            // Calling the method with a specified number of times using named parameters
            Console.WriteLine("\nCalling with specified times:");
            PrintStringMultipleTimes(message: "Hello", times: 3);
            */

            /* //problem 11

            int?[] nullableArray = new int?[] { 1, 2, 3, null, 5 };

            // Use the null propagation operator (?.) to safely access array elements
            Console.WriteLine("Using null propagation operator to safely access elements:");

            for (int i = 0; i < nullableArray.Length; i++)
            {
                // Using ?. to safely access each element and print it, or print "null" if it's null
                Console.WriteLine(nullableArray[i]?.ToString() ?? "null");
            }

            // Demonstrate null propagation with a null array (array itself is null)
            int?[] nullArray = null;

            Console.WriteLine("\nAttempting to access a null array using ?. operator:");
            // Using ?. to safely check if the array is null before accessing properties
            Console.WriteLine(nullArray?.Length ?? 0); // Will print 0 if the array is null
            */

            /* //problem 12

            Console.Write("Enter a day of the week (e.g., Monday, Tuesday, etc.): ");
            string dayOfWeek = Console.ReadLine()?.Trim();

            // Use a switch expression to map the day to its corresponding number
            int dayNumber = dayOfWeek switch
            {
                "Monday" => 1,
                "Tuesday" => 2,
                "Wednesday" => 3,
                "Thursday" => 4,
                "Friday" => 5,
                "Saturday" => 6,
                "Sunday" => 7,
                _ => -1 // Return -1 if the input is invalid
            };

            // Display the corresponding day number
            if (dayNumber != -1)
            {
                Console.WriteLine($"The corresponding number for {dayOfWeek} is: {dayNumber}");
            }
            else
            {
                Console.WriteLine("Invalid day entered. Please enter a valid day of the week.");
            }
            */

            /* //problem 13
            // Calling the method with individual values
            Console.WriteLine("Sum of individual values:");
            int result1 = SumArray(1, 2, 3, 4, 5);
            Console.WriteLine($"The sum is: {result1}");

            // Calling the method with an array of integers
            Console.WriteLine("\nSum of values from an array:");
            int[] array = { 10, 20, 30 };
            int result2 = SumArray(array);
            Console.WriteLine($"The sum is: {result2}");
            */


        }

    }
    
    
}
