using System;

namespace HandsOnInterfaces
{
    interface IShape
    {
        void Area(); //abstract method
    }
    struct Square : IShape
    {
        int l;

        public Square(int l)
        {
            this.l = l;
        }

        public void Area() //interface method
        {
            Console.WriteLine("Area of Square:{0}", 4 * l);
        }
    }
    class Circle : IShape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public void Area() //interface method
        {
            Console.WriteLine("Area of Circle: " + Math.PI * r * r);
        }
        public void M() { }
    }
    class Rectangle : IShape
    {
        int l;
        int w;

        public Rectangle(int l, int w)
        {
            this.l = l;
            this.w = w;
        }

        public void Area()
        {
            Console.WriteLine("Area of Rectangle: " + (l * w));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //access only interface members
            IShape circle = new Circle(12.3);
            circle.Area();
            IShape rectangle = new Rectangle(12, 34);
            rectangle.Area();
            IShape square = new Square(12);
            square.Area();
            //access all the members 
            Circle circle1 = new Circle(34.5);
            circle1.Area(); //access interface methods and circle class methods.
            circle1.M();
        }
    }
}
