using System;
using System.Collections.Generic;

namespace Day_5__Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //Print Numbers in a Range

            Console.Write("Enter a positive integer: ");
            int number;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            Console.WriteLine("\nOutput:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i);
                if (i < number) Console.Write(", "); // Add a comma between numbers
            }
            Console.WriteLine();
            */

            /* //Display Multiplication Table

            Console.Write("Enter an integer: ");
            int number;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }

            Console.WriteLine("\nMultiplication Table:");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number * i);
                if (i < 12) Console.Write(", "); // Add a comma between numbers
            }
            Console.WriteLine();
            */

            /* // List Even Numbers

            Console.Write("Enter a positive integer: ");
            int number;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer:");
            }

            Console.WriteLine("\nEven Numbers:");
            for (int i = 2; i <= number; i += 2) // Start from 2 and increment by 2 for even numbers
            {
                Console.Write(i);
                if (i + 2 <= number) Console.Write(", "); // Add a comma between numbers
            }
            Console.WriteLine();
            */

            /* //Compute Exponentiation

            Console.Write("Enter the base number: ");
            int baseNumber;
            while (!int.TryParse(Console.ReadLine(), out baseNumber))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the base:");
            }

            Console.Write("Enter the exponent: ");
            int exponent;
            while (!int.TryParse(Console.ReadLine(), out exponent))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the exponent:");
            }

            // Calculate the power using Math.Pow
            long result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            Console.WriteLine($"\nResult: {baseNumber}^{exponent} = {result}");
            */

            /* //Reverse a Text String

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Reverse the string
            string reversed = ReverseString(input);

            // Output the reversed string
            Console.WriteLine($"\nReversed String: {reversed}");
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }*/

            /* //Reverse an Integer Value

            Console.Write("Enter an integer: ");
            int number;

            // Validate user input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }

            // Reverse the digits
            int reversedNumber = ReverseDigits(number);

            // Output the reversed integer
            Console.WriteLine($"\nReversed Integer: {reversedNumber}");
        }

        static int ReverseDigits(int num)
        {
            int reversed = 0;

            while (num != 0)
            {
                int digit = num % 10;       // Extract the last digit
                reversed = reversed * 10 + digit; // Append it to the reversed number
                num /= 10;                 // Remove the last digit from the number
            }

            return reversed;
        }*/

            /* // Find Longest Distance Between Matching Elements

            Console.WriteLine("Enter the array of integers, separated by spaces:");
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputArray, int.Parse);

            // Find the longest distance
            int longestDistance = FindLongestDistance(numbers);

            // Output result
            Console.WriteLine($"\nThe longest distance between two identical elements is: {longestDistance}");
        }

        static int FindLongestDistance(int[] arr)
        {
            // Dictionary to store the first occurrence index of each number
            Dictionary<int, int> firstOccurrence = new Dictionary<int, int>();
            int maxDistance = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (firstOccurrence.ContainsKey(arr[i]))
                {
                    // Calculate the distance from the first occurrence
                    int distance = i - firstOccurrence[arr[i]];
                    maxDistance = Math.Max(maxDistance, distance);
                }
                else
                {
                    // Store the first occurrence index
                    firstOccurrence[arr[i]] = i;
                }
            }

            return maxDistance;
            */

            /* //Reverse Words in a Sentence

            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            // Split the sentence into words
            string[] words = sentence.Split(' ');

            // Reverse the order of the words
            Array.Reverse(words);

            // Join the words back into a sentence
            string reversedSentence = string.Join(" ", words);

            // Output the result
            Console.WriteLine($"\nReversed Sentence: {reversedSentence}");
            */
        }
    }
}
