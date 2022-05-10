using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    class Demo4
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Square(double a)
        {
            return a * a;
        }
        public bool IsEven(int no)
        {
            return no % 2 == 0 ? true : false;
        }
        public void Greet(string n)
        {
            Console.WriteLine("Hello " + n);
        }
        static void Main()
        {
            Demo4 obj = new Demo4();
            //Func delegate are refer methods with return value
            Func<int, int, int> func = obj.Add;
            int result=func(2, 3);
            Console.WriteLine(result);
            Func<double, double> func1 = obj.Square;
            Console.WriteLine(func1(12));
            Func<int, bool> func2 = obj.IsEven;
            if (func2(12))
            {
                Console.WriteLine("Even Value");
            }
            else
                Console.WriteLine("Odd Value");
            //Action delegate invoke functions with no retrun type
            Action<string> action = obj.Greet;
            action("Sachin");
            //Predicate delegate invoke methods which return boolean value
            Predicate<int> predicate = obj.IsEven;
            if (predicate(12))
            {
                Console.WriteLine("Even Value");
            }
            else
                Console.WriteLine("Odd Value");



        }
    }
}
