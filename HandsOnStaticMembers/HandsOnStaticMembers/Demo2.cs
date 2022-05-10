using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStaticMembers
{
    class Circle
    {
        private  double r;
        private static double PI;
        public Circle(double r)
        {
            this.r = r;
            Console.WriteLine("Object is Created");
        }
        //static constructor
        //static constructor are used to define static variables
        static Circle()
        {
            PI = 3.14;
            Console.WriteLine("PI value is set to 3.14");
        }
        public  void Area()
        {
            Console.WriteLine("Area of Circle: " + (PI * r * r));
        }
    }
    class Demo2
    {
        static void Main()
        {
            Circle c1 = new Circle(12.3);
            Circle c2 = new Circle(34.5);
            c1.Area();
            c2.Area();

        }
    }
}
