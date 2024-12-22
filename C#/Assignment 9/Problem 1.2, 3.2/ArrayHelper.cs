using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_1._2
{
    public static class ArrayHelper
    {
        #region Problem 1.2
        //// Generic method to reverse an array
        //public static T[] ReverseArray<T>(T[] array)
        //{
        //    // Create a new array to hold the reversed elements
        //    T[] reversedArray = new T[array.Length];

        //    // Iterate through the original array in reverse order
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        reversedArray[i] = array[array.Length - 1 - i];
        //    }

        //    return reversedArray; // Return the new reversed array
        //} 
        #endregion

        #region Problem 3.2
        //// Generic method to swap two elements in an array
        //public static void Swap<T>(T[] array, int index1, int index2)
        //{
        //    // Validate indices
        //    if (array == null)
        //    {
        //        throw new ArgumentNullException(nameof(array), "Array cannot be null.");
        //    }
        //    if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
        //    {
        //        throw new ArgumentOutOfRangeException("Indices are out of range.");
        //    }

        //    // Swap the elements
        //    T temp = array[index1];
        //    array[index1] = array[index2];
        //    array[index2] = temp;
        //} 
        #endregion

        #region Problem 4.2
        // Generic method to find the maximum element in an array
        public static T FindMaximum<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            T maxElement = array[0]; // Assume the first element is the maximum

            // Iterate through the array to find the maximum element
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(maxElement) > 0)
                {
                    maxElement = array[i]; // Update maxElement if a larger element is found
                }
            }

            return maxElement; // Return the maximum element
        } 
        #endregion
    }
}
