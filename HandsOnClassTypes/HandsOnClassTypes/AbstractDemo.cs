using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    abstract class Shape
    {
        public string shape;

        protected Shape(string shape)
        {
            this.shape = shape;
        }

        //abstract method(method with out defination)
        public abstract void Area();
        public void GetShape()
        {
            Console.WriteLine("I am {0}", shape);
        }
    }
    class Circle:Shape
    {
        private double r;

        public Circle(double r):base("Circle")
        {
            this.r = r;
        }

        public override void Area()
        {
            double area = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area of Circle: " + area);
        }
    }
    class Reactangle:Shape
    {
        private int l, w;

        public Reactangle(int l, int w):base("Rectangle")
        {
            this.l = l;
            this.w = w;
        }

        public override void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (l * w));
        }
    }
    class AbstractDemo
    {
        static void Main()
        {
            Shape ob = new Circle(12.2);
            ob.GetShape();
            ob.Area();
            ob = new Reactangle(2, 3);
            ob.GetShape();
            ob.Area();
            Console.ReadKey();
        }
    }
}
