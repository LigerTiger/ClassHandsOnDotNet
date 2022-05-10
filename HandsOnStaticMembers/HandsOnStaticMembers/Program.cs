using System;

namespace HandsOnStaticMembers
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public static string TrainingName;
        public const string Company = "CG";
        public void Details()
        {
            Console.WriteLine("ID:{0} Name:{1} Training:{2} Company: {3} ", employeeId, employeeName, TrainingName,Company);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //access the static data
            Console.WriteLine("Welcome to {0} Employees", Employee.Company);
            Employee.TrainingName = "Dotnet Core with Azure";
            Employee e1 = new Employee() { employeeId = 3089342, employeeName = "Amith" };
            Employee e2 = new Employee() { employeeId = 324342, employeeName = "Madhavi" };
            Employee e3 = new Employee() { employeeId = 67765, employeeName = "Hamanshi" };
            e1.Details();
            e2.Details();
            e3.Details();
            Employee.TrainingName = "Java FSD with AWS";
            Employee e4 = new Employee() { employeeId = 545445, employeeName = "Kumar Singh" };
            Employee e5 = new Employee() { employeeId = 4445, employeeName = "Navya" };
            Employee e6 = new Employee() { employeeId = 6744765, employeeName = "Jahnavi" };
            e4.Details();
            e5.Details();
            e6.Details();
        }
    }
}
