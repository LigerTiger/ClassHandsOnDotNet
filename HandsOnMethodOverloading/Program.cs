using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnMethodOverloading
{
    class Calculate
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        public double Add(double a,double b)
        {
            return a + b;
        }
        public float Add(float a, float b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, GoodMoring");
            int k = 10;
            Console.WriteLine(k);
            Calculate calculate = new Calculate();
            int result=calculate.Add(1, 2);
            Console.WriteLine(result);
            double result1=calculate.Add(12.2, 23.3);
            Console.WriteLine(result1);
           result= calculate.Add(1, 2, 3);
            Console.WriteLine(result);
            float result2=calculate.Add(12.3f, 23.4f);
            Console.WriteLine(result2);
            Console.ReadKey();
        }
    }
}
