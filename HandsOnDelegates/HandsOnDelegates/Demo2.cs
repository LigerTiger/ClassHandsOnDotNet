using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void MyCalculateDelegate(int a, int b);
    class Calculate
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition: " + (a + b));
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication: " + (a * b));
        }
        public void Div(int a, int b)
        {
            Console.WriteLine("Division: " + (a / b));
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction: " + (a - b));
        }
    }
    class Demo2
    {
        static void Main()
        {
            Calculate ob = new Calculate();
            //instantiate delegate
            MyCalculateDelegate delObj = new MyCalculateDelegate(ob.Add);
            //add multiple method references
            delObj += ob.Div;
            delObj += ob.Sub;
            delObj += ob.Mul;
            //invoking delegate
            delObj(10, 2);

        }
    }
}
