using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Method-hiding in Inheritance
    class Employee
    {
        public int eId;
        public string eName;
        public void Details()
        {
            Console.WriteLine("ID: " + eId);
            Console.WriteLine("Ename: " + eName);
        }
    }
    class Manager:Employee
    {
        public string type;
       
         new public void Details()
        {
            base.Details(); //calls Employee Details()
            Console.WriteLine("Manager Type: " + type);
        }
    }
    class Demo7
    {
        static void Main()
        {
            

            Manager obj = new Manager();
            obj.eId = 1000;
            obj.eName = "Jon";
            obj.type = "Product Manager";
            obj.Details(); //Manger Details
            Employee obj2 = new Employee();
            obj2.eId = 100;
            obj2.eName = "Sourab";
            obj2.Details();

            Employee obj3 = new Manager(); //access only employee methods and override methods of Manager
            obj3.eId = 100;
            obj3.eName = "Sourab";
           
            obj3.Details(); //Invoking Details()of Employee
        }
    }
}
