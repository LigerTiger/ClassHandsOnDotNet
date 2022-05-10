using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDatatypes
{
    class Demo
    {
        static void Main()
        {
            Console.WriteLine("Enter your Name");
            string s = Console.ReadLine(); //Reads a value from console input
            Console.WriteLine("Good Morning " + s);
            Console.ReadKey();
        }
    }
}
