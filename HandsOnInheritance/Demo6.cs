using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Hierarchical Inheritance
    class Class1 //base class
    {
        public void M(){}
    }
    //Derived Class
    class Class2 : Class1 {
    public void M1()
        {
           
        }
    }
    //Dervied Class
    class Class3 : Class1 {
    public void M2() { }
    }
    class Demo6
    {
        public void M1()
        {
            Class1 class1 = new Class1();
            class1.M();
        }
        static void Main()
        {
            Class2 class2 = new Class2();
            class2.M();
            class2.M1();
            Class3 class3 = new Class3();
            class3.M();
            class3.M2();
        }
    }
}
