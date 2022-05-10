using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeService
{
    public class Employee
    {
        public int employeeId;
        public string employeeName;
        public DateTime joiningDate;
        public string designation;
        public double salary;
        public string workLocation;
        public void Details()
        {
            Console.WriteLine("ID: " + employeeId);
            Console.WriteLine("Name: " + employeeName);
            Console.WriteLine("JoinDate: " + joiningDate);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("WorkLocation: " + workLocation);
        }
    }
}
