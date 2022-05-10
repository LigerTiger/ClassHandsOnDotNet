using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10; //local variable
            Console.WriteLine("a value: " + a);
            //value dataypes
            //integer types
            byte b = 10;
            short s = 123;
            int i = 342034;
            long l = 324093439;
            ulong ul = 3240934;
            uint ui = 343;
            ushort us = 3232;
            sbyte sb = 33;
            //decmal types
            double d1 = 12.34;
            float f1 = 45.678f;
            decimal m1 = 23.334343m;
            char ch = 'a';
            bool bl = true;
            //reference types
            string st = "Hello Users";
            Console.ReadKey();
        }
    }
}
