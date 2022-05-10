using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverriding
{
    class Employee
    {
        public int Id;
        public string Name;
        public double ta;
        public double da;
        public double Salary;

        public Employee(int id, string name, double ta, double da)
        {
            Id = id;
            Name = name;
            this.ta = ta;
            this.da = da;
        }

        public virtual void TotalSalary()
        {
            Salary = ta + da;
        }
    }
    class JuniorProgrammer:Employee
    {
        public JuniorProgrammer(int id, string name, double ta, double da):base(id,name,ta,da)
        {
            Id = id;
            Name = name;
            this.ta = ta;
            this.da = da;
        }
    }
    class Manager : Employee
    {
        public double bonous;
        public Manager(int id, string name, double ta, double da, double bonous) : base(id, name, ta, da)
        {
            this.bonous = bonous;
        }
        public override void TotalSalary()
        {
            base.TotalSalary();
            Salary = Salary + bonous;

        }
    }
     class Demo2
    {
        static void Main()
        {
            Console.WriteLine("1.JuniorProgammer");
            Console.WriteLine("2.Manager");
            Console.WriteLine("Enter your Role");
            int role = int.Parse(Console.ReadLine());

            Employee employee;
            switch (role)
            {
                case 1:
                    employee = new JuniorProgrammer(13232, "Ram", 14000, 23000);
                    employee.TotalSalary();
                    Console.WriteLine(employee.Salary);
                    break;
                case 2:
                    employee = new Manager(3232, "Simaran", 23000, 34000, 45000);
                    employee.TotalSalary();
                    Console.WriteLine(employee.Salary);
                    break;


            }
            Console.ReadKey();


        }
    }
}
