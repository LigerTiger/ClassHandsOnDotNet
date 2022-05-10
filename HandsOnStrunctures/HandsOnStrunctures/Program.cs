using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrunctures
{
    struct Box
    {
        //variables
        public int length;
        public int width;
        //method
        public void Area()
        {
            int area = length * width;
            Console.WriteLine("Area of the Box: " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //struct object creation
            Box b1 = new Box();
            b1.length = 12;
            b1.width = 23;
            b1.Area();
            Box b2 = new Box() { length = 23, width = 45 };
            b2.Area();
            Box b3; //we can create struct object with out using new keyword.
            b3.length = 34;
            b3.width = 45;
            b3.Area();
            Console.ReadKey();
        }
    }
}
