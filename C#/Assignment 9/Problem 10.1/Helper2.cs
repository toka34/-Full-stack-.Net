using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_09.Problem_14;

namespace Day_09.Problem_10
{
    public static class Helper2
    {
        #region Problem 10
        public static Employee? SearchArray(Employee[] employees, Employee target)
        {
            foreach (var employee in employees)
            {
                if (employee.Equals(target))
                {
                    return employee; // Return the found employee
                }
            }
            return null; // Return null if not found
        }
        #endregion

        #region Problem 14
        // Method to search for employees by department
        public static Employee[] SearchByDepartment(Employee[] employees, Department department)
        {
            Employee[] matchingEmployees = new Employee[employees.Length];
            int count = 0;

            foreach (var employee in employees)
            {
                if (employee.Department.Equals(department))
                {
                    matchingEmployees[count] = employee;
                    count++;
                }
            }

            // Resize the array to the number of matches found
            Array.Resize(ref matchingEmployees, count);
            return matchingEmployees;
        } 
        #endregion

        #region Problem 12
        // Generic method to replace all occurrences of a specified value in an array
        public static void ReplaceArray<T>(T[] array, T oldValue, T newValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(oldValue))
                {
                    array[i] = newValue;
                }
            }
        } 
        #endregion
    }
}
