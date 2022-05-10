using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Constructors in Inheritance
    class I
    {
        public I() //default constructor
        {
            Console.WriteLine("I is base Class");
        }
    }
    class J:I
    {
        public J() //defauct constructor
        {
            Console.WriteLine("J is Derived Class ");
        }
    }
    class Demo3
    {
        static void Main()
        {
            J obj = new J(); //first base class constructor executed then derivec class construnctor executed.
            Console.ReadKey();
            

        }
    }
}
