using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day_09.Problem_14;

namespace Day_09.Problem_10
{
    public struct Employee // Change internal to public
    {
        // Attributes
        private int EmpID;
        private string EmpName;
        private decimal empsalary;
        public Department Department { get; set; }

        // Properties
        public string GetName()
        {
            return EmpName;
        }

        public void SetName(string value)
        {
            EmpName = value.Length <= 20 ? value : value.Substring(0, 20);
        }

        public decimal Salary
        {
            get { return empsalary; }
            set { empsalary = value < 4000 ? 4000 : value; }
        }

        public int Age { get; set; }

        // Constructor
        public Employee(int _id, string _Name, decimal _salary, int _Age, Department department)
        {
            EmpID = _id;
            EmpName = _Name;
            empsalary = _salary;
            Age = _Age;
            Department = department;
        }

        // Override ToString
        public override string ToString()
        {
            return $"Emp Id: {EmpID}, Name: {EmpName}, Salary: {empsalary}, Age: {Age}, Department: {Department}";
        }

        // Override Equals
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return EmpID == employee.EmpID; // Compare based on EmpID
            }
            return false;
        }

        // Override GetHashCode
        public override int GetHashCode()
        {
            return EmpID.GetHashCode(); // Use EmpID for hash code
        }

        // Bonus property
        public decimal Bonus
        {
            get { return empsalary * 0.1M; }
        }
    }
}
