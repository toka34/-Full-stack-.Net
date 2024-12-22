using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_4
{
    public class Child : Parent
    {
        // Constructor
        public Child(decimal salary) : base(salary)
        {
        }

        // Method to display the salary
        public void DisplaySalary()
        {
            Console.WriteLine($"The salary is: {Salary}");
        }
    }
}
