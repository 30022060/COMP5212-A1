using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_employee;

namespace Question4
{//LIAM SULLIVAN STUDENT ID: 30022060
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Employee e1 = new Employee();
                Console.Write("Enter Employee's First Name: ");
                e1.FirstName = Console.ReadLine();
                Console.Write("Enter Employee's Last Name: ");
                e1.LastName = Console.ReadLine();
                Console.WriteLine("New Employee Record Created...");
                Console.Write("\nYear that the employee started working: ");
                e1.YearStarted = int.Parse(Console.ReadLine());

                Console.WriteLine($"Employee {(e1.GetFullName())}has been working for {(e1.GetYearStarted())} years.");
                

                
                while(true)
                {
                    Console.Write("Would you like to enter another employee record?\nY/N:");
                    string YorN = Console.ReadLine().ToUpper();
                    if (YorN == "Y")
                    break;

                    else
                    Console.WriteLine("Quitting Program... ");
                    Console.ReadLine();
                    return;
                }
                
            }
        }
    }
    
}
