using System;

namespace HandsOnClassTypes
{
    static class Compute
    {
        //define only static members
        public static int Add(int a,int b)
        {
            return a + b;
        }
        public static double Square(double a)
        {
            return a * a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Compute.Add(1, 2);
            Compute.Square(3);
        }
    }
}
