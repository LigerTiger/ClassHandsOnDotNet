using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeService;
namespace Employee_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.employeeId = 3240983;
            e1.employeeName = "Pratiek";
            e1.joiningDate = DateTime.Parse("04/01/2022");
            e1.designation = "Trainee Associate";
            e1.salary = 21000;
            e1.workLocation = "Pune";
            e1.Details();
            Employee e2 = new Employee();
            e2.employeeId = 423432;
            Console.WriteLine("Enter EmployeeName");
            e2.employeeName = Console.ReadLine();
            Console.WriteLine("Enter JointDate");
            e2.joiningDate = DateTime.Parse(Console.ReadLine()); //convert string into date
            Console.WriteLine("Enter Salary");
            e2.salary = double.Parse(Console.ReadLine());
            e2.designation = "Trainee Associate";
            Console.WriteLine("Enter WorkLocation");
            e2.workLocation = Console.ReadLine();
            e2.Details();
            Console.ReadKey();
        }
    }
}
