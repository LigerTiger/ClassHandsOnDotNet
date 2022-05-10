using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    class Rectangle
    {
        private int length;
        private int width;

        public Rectangle(int length, int width) //parameterized constructor
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(Rectangle rectangle) //copy details from one oject to another object.
        {
            this.length = rectangle.length;
            this.width = rectangle.width;
        }
        public void Area()
        {
            Console.WriteLine("Area of Rectnangle: " + (length * width));
        }
    }
    class Test_Rectangle
    {
        static void Main()
        {
            Rectangle r1 = new Rectangle(23, 34);
            r1.Area();
            Rectangle r2 = new Rectangle(34, 45);
            r2.Area();
            Rectangle r3 = new Rectangle(r2);
            r3.Area();
        }
    }
}
