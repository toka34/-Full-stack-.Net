using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_09.Problem_4
{
    public class Parent
    {
        // Non-virtual Salary property
        public decimal Salary { get; private set; } // Private setter to prevent modification

        // Constructor
        public Parent(decimal salary)
        {
            Salary = salary;
        }
    }
}
