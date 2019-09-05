using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee
{//LIAM SULLIVAN STUDENT ID: 30022060
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearStarted { get; set; }

        public Employee()
        {
            Console.WriteLine("\t***EMPLOYEE RECORD CREATOR***\n");
        }

        public Employee(string firstName, string lastName)
        {
            Console.WriteLine("***Creating new Employee Record***");
            FirstName = firstName;
            LastName = lastName;          
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName} ";
        }
        public int GetYearStarted()
        {
            return 2019 - YearStarted;
        }
    }
}
