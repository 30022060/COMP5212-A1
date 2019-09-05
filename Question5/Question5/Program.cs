using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_employee;
using class_driver1;

namespace Question5
{//LIAM SULLIVAN STUDENT ID: 30022060
    class Program
    {
        static void Main(string[] args)
        { 
            Driver d1 = new Driver();
            Console.Write("Enter Employee's First Name: ");
            d1.FirstName = Console.ReadLine();
            Console.Write("Enter Employee's Last Name: ");
            d1.LastName = Console.ReadLine();
            Console.Write("Enter Vehicle Type: ");
            d1.Vehicle = Console.ReadLine();

            Console.WriteLine($"New Employee Record Created...\nAdding Employee as a new driver to drive {d1.Vehicle}");
            Console.Write("\nEnter Vehicle's License Number: ");
            d1.DriverLicenseNo = Console.ReadLine();

            Console.WriteLine($"{d1.ProcessDriver()}\n{d1.LicenseNo()}");
            Console.ReadLine();
            
          
        }
    }
}
