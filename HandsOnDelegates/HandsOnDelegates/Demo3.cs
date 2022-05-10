using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate double CubeDelegate(double i);
    class Demo3
    {
        public static double Cube(double no)
        {
            return Math.Pow(no, 3);

        }
        static void Main()
        {
            CubeDelegate delObj = new CubeDelegate(Cube);
            double result=delObj(5);
            Console.WriteLine("Result: " + result);
            CubeDelegate delObj1 = (i) => i * i * i; //lambda expression
            result = delObj1(10);
            Console.WriteLine("Result: " + result);

        }
    }
}
