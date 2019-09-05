using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_employee;

namespace class_driver1
{
    public class Driver : Employee
    {//LIAM SULLIVAN STUDENT ID:30022060
        public string Vehicle { get; set; }
        public string DriverLicenseNo { get; set; }

        public Driver()
        {
        }
        public Driver(string vehicle, string licneseNo)
        {
            Vehicle = vehicle;
            DriverLicenseNo = licneseNo;
        }
        public string ProcessDriver()
        {
            return $"Driver Name: {GetFullName()}\nVehicle: {Vehicle}";
        }
        public string LicenseNo()
        {
            return $"Driver's License Number: {DriverLicenseNo}";
        }
    }
}
