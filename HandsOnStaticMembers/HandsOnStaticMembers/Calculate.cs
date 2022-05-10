using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStaticMembers
{
    class Calculate
    {
        private static int bookingNo;
        public static int BookingNo //staic property
        {
            get { return BookingNo; }
            set { bookingNo = value; }
        }
        //static methods
        public static void Add(int a,int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public static double Sqaure(double a)
        {
            return a * a;
        }
    }
    class Test_Calculate
    {
        static void Main()
        {
            Calculate.Add(3, 4);
            Calculate.BookingNo = 32498324;
            double result=Calculate.Sqaure(12);
            Console.WriteLine("Square {0}", result);
        }
    }
}
