using System;

namespace Day_4
{
    internal class Program
    {

        
        static void Main(string[] args)
        {


            // --problem 1--

            //// (a) Using `new int[size]`
            //int[] array1 = new int[5];

            //// (b) Using initializer list
            //int[] array2 = { 10, 20, 30, 40, 50 };

            //// (c) Using Array syntax sugar
            //int[] array3 = new[] { 100, 200, 300, 400, 500 };

            //// 2. Assign values to each element in array1
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = (i + 1) * 5; // Assigning multiples of 5
            //}

            //// Print values of all arrays
            //Console.WriteLine("Array 1 values:");
            //foreach (var value in array1)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("\nArray 2 values:");
            //foreach (var value in array2)
            //{
            //    Console.WriteLine(value);
            //}

            //Console.WriteLine("\nArray 3 values:");
            //foreach (var value in array3)
            //{
            //    Console.WriteLine(value);
            //}

            //// 3. Demonstrating IndexOutOfRangeException
            //try
            //{
            //    Console.WriteLine("\nAccessing out-of-bounds index:");
            //    int outOfBoundsValue = array1[10]; // This will throw an exception
            //    Console.WriteLine(outOfBoundsValue);
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"Exception caught: {ex.Message}");
            //}



            // --problem 2--

            //// 1. Create two arrays
            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2;

            //// 2. Perform a shallow copy
            //arr2 = arr1; // Shallow copy
            //Console.WriteLine("After shallow copy:");
            //Console.WriteLine("Original arr1: " + string.Join(", ", arr1));
            //Console.WriteLine("Copied arr2: " + string.Join(", ", arr2));

            //// Modify arr1 and demonstrate how it affects arr2
            //arr1[0] = 99;
            //Console.WriteLine("\nAfter modifying arr1[0]:");
            //Console.WriteLine("Original arr1: " + string.Join(", ", arr1));
            //Console.WriteLine("Copied arr2: " + string.Join(", ", arr2));

            //// 3. Perform a deep copy using the Clone method
            //int[] arr3 = (int[])arr1.Clone(); // Deep copy
            //Console.WriteLine("\nAfter deep copy using Clone:");
            //Console.WriteLine("Original arr1: " + string.Join(", ", arr1));
            //Console.WriteLine("Copied arr3: " + string.Join(", ", arr3));

            //// Modify arr1 and demonstrate that it does not affect arr3
            //arr1[1] = 77;
            //Console.WriteLine("\nAfter modifying arr1[1]:");
            //Console.WriteLine("Original arr1: " + string.Join(", ", arr1));
            //Console.WriteLine("Copied arr3: " + string.Join(", ", arr3));


            // --problem 3--

            //int[,] grades = new int[3, 3];

            //Console.WriteLine("Enter the grades for 3 students in 3 subjects:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Subject {j + 1}: ");
            //        while (!int.TryParse(Console.ReadLine(), out grades[i, j]) || grades[i, j] < 0 || grades[i, j] > 120)
            //        {
            //            Console.WriteLine("Invalid input. Please enter a grade between 0 and 120.");
            //            Console.Write($"Subject {j + 1}: ");
            //        }
            //    }
            //}

            //Console.WriteLine("\nGrades for each student:");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{grades[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}


            //--problem 4--

            //// Initial array
            //int[] arr = { 5, 3, 8, 6, 2 };

            //Console.WriteLine("Original array:");
            //Console.WriteLine(string.Join(", ", arr));

            //// 1. Sort
            //// Sorts the array in ascending order
            //Array.Sort(arr); 
            //Console.WriteLine("\nAfter Sort:");
            //Console.WriteLine("Array is sorted in ascending order.");
            //Console.WriteLine(string.Join(", ", arr));

            //// Before : 5, 3, 8, 6, 2
            //// After : 2, 3, 5, 6, 8

            //// 2. Reverse
            //// Reverses the array order
            //Array.Reverse(arr);
            //Console.WriteLine("\nAfter Reverse:");
            //Console.WriteLine("Array is reversed.");
            //Console.WriteLine(string.Join(", ", arr));

            //// Before : 2, 3, 5, 6, 8
            //// After : 8, 6, 5, 3, 2

            //// 3. IndexOf
            //// Finds the index of a value 
            //int valueToFind = 2;
            //int index = Array.IndexOf(arr, valueToFind); 
            //Console.WriteLine("\nUsing IndexOf to find value 2:");
            //if (index != -1)
            //{
            //    Console.WriteLine($"Value {valueToFind} is found at index {index}.");
            //}
            //else
            //{
            //    Console.WriteLine($"Value {valueToFind} is not found in the array.");
            //}

            //// Before : 8, 6, 5, 3, 2
            //// After : find 2 and return 4

            //// 4. Copy
            //// Copies elements from an array to another
            //int[] copiedArr = new int[arr.Length];
            //Array.Copy(arr, copiedArr, arr.Length);
            //Console.WriteLine("\nAfter Copy:");
            //Console.WriteLine("Copied array:");
            //Console.WriteLine(string.Join(", ", copiedArr));

            //// Before : 8, 6, 5, 3, 2
            //// After : 8, 6, 5, 3, 2

            //// 5. Clear
            //// set the elements to 0
            //Array.Clear(arr, 0, arr.Length);
            //Console.WriteLine("\nAfter Clear:");
            //Console.WriteLine("all elements set to 0.");
            //Console.WriteLine(string.Join(", ", arr));

            //// Before : 8, 6, 5, 3, 2
            //// After : 0, 0, 0, 0, 0


            // --problem 5--

            //int[] arr = { 10, 20, 30, 40, 50 };

            //// 1. for loop
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //// 2. foreach loop
            //Console.WriteLine("\nUsing foreach loop:");
            //foreach (int value in arr)
            //{
            //    Console.WriteLine(value);
            //}

            //// 3. while loop in reverse order
            //Console.WriteLine("\nUsing while loop (reverse order):");
            //int index = arr.Length - 1; 
            //while (index >= 0)
            //{
            //    Console.WriteLine(arr[index]);
            //    index--; 
            //}


            // --problem 6--

            //int number;
            //bool isValidInput;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string userInput = Console.ReadLine();

            //    // Try to parse the input and validate conditions
            //    isValidInput = int.TryParse(userInput, out number) && number > 0 && number % 2 != 0;

            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a positive odd number.");
            //    }

            //} while (!isValidInput); // Repeat until valid input is provided

            //Console.WriteLine($"Thank you! You entered a valid number: {number}");


            // --problem 7--

            //int[,] matrix = {
            //{ 1, 2, 3 },
            //{ 4, 5, 6 },
            //{ 7, 8, 9 }
            //};

            //Console.WriteLine("Matrix:");
            //for (int i = 0; i < matrix.GetLength(0); i++) 
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++) 
            //    {
            //        Console.Write(matrix[i, j] + "\t"); 
            //    }
            //    Console.WriteLine();
            //}


            // --problem 8--

            //Console.Write("Enter a month number (1-12): ");
            //string input = Console.ReadLine();
            //int monthNumber;

            //if (!int.TryParse(input, out monthNumber) || monthNumber < 1 || monthNumber > 12)
            //{
            //    Console.WriteLine("Invalid input. Please enter a number between 1 and 12.");
            //    return;
            //}

            //// Determine the month name using if-else
            //string monthNameIfElse;
            //if (monthNumber == 1) monthNameIfElse = "January";
            //else if (monthNumber == 2) monthNameIfElse = "February";
            //else if (monthNumber == 3) monthNameIfElse = "March";
            //else if (monthNumber == 4) monthNameIfElse = "April";
            //else if (monthNumber == 5) monthNameIfElse = "May";
            //else if (monthNumber == 6) monthNameIfElse = "June";
            //else if (monthNumber == 7) monthNameIfElse = "July";
            //else if (monthNumber == 8) monthNameIfElse = "August";
            //else if (monthNumber == 9) monthNameIfElse = "September";
            //else if (monthNumber == 10) monthNameIfElse = "October";
            //else if (monthNumber == 11) monthNameIfElse = "November";
            //else monthNameIfElse = "December";

            //Console.WriteLine($"(if-else) The month is: {monthNameIfElse}");

            //// Determine the month name using switch
            //string monthNameSwitch;
            //switch (monthNumber)
            //{
            //    case 1: monthNameSwitch = "January"; break;
            //    case 2: monthNameSwitch = "February"; break;
            //    case 3: monthNameSwitch = "March"; break;
            //    case 4: monthNameSwitch = "April"; break;
            //    case 5: monthNameSwitch = "May"; break;
            //    case 6: monthNameSwitch = "June"; break;
            //    case 7: monthNameSwitch = "July"; break;
            //    case 8: monthNameSwitch = "August"; break;
            //    case 9: monthNameSwitch = "September"; break;
            //    case 10: monthNameSwitch = "October"; break;
            //    case 11: monthNameSwitch = "November"; break;
            //    case 12: monthNameSwitch = "December"; break;
            //    default: monthNameSwitch = "Invalid"; break; 
            //}

            //Console.WriteLine($"(switch) The month is: {monthNameSwitch}");


            // --problem 9--

            //int[] arr = { 8, 3, 5, 3, 7, 3, 2 };

            //// 1. Sort the array using Array.Sort()
            //Console.WriteLine("Original Array:");
            //Console.WriteLine(string.Join(", ", arr));

            //Array.Sort(arr); // Sorts the array in ascending order
            //Console.WriteLine("\nSorted Array:");
            //Console.WriteLine(string.Join(", ", arr));

            //// 2. Search for a specific value using Array.IndexOf() and Array.LastIndexOf()
            //Console.Write("\nEnter a value to search for: ");
            //string input = Console.ReadLine();
            //int valueToSearch;

            //if (int.TryParse(input, out valueToSearch))
            //{
            //    // Search for the first occurrence
            //    int firstIndex = Array.IndexOf(arr, valueToSearch);
            //    if (firstIndex != -1)
            //    {
            //        Console.WriteLine($"First occurrence of {valueToSearch} is at index: {firstIndex}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{valueToSearch} is not found in the array.");
            //    }

            //    // Search for the last occurrence
            //    int lastIndex = Array.LastIndexOf(arr, valueToSearch);
            //    if (lastIndex != -1)
            //    {
            //        Console.WriteLine($"Last occurrence of {valueToSearch} is at index: {lastIndex}");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}


            //--problem 10--

            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// Calculate the sum using a for loop
            //int sumForLoop = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumForLoop += numbers[i];
            //}
            //Console.WriteLine($"Sum calculated using for loop: {sumForLoop}");

            //// Calculate the sum using a foreach loop
            //int sumForEachLoop = 0;
            //foreach (int num in numbers)
            //{
            //    sumForEachLoop += num;
            //}
            //Console.WriteLine($"Sum calculated using foreach loop: {sumForEachLoop}");


            // --part 2--

            //    enum DayOfWeek
            //{
            //    Monday = 1,
            //    Tuesday,
            //    Wednesday,
            //    Thursday,
            //    Friday,
            //    Saturday,
            //    Sunday
            //}

            //static void Main(string[] args)
            //{
            //    Console.Write("Enter a number (1-7) to get the corresponding day: ");
            //    string input = Console.ReadLine();

            //    // Validate the input
            //    if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
            //    {
            //        try
            //        {
            //            // Convert the integer to the DayOfWeek enum
            //            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
            //            Console.WriteLine($"The day corresponding to {dayNumber} is: {day}");
            //        }
            //        catch (ArgumentException)
            //        {
            //            Console.WriteLine("Invalid day number.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            //    }
            //}

        }

    }
}
