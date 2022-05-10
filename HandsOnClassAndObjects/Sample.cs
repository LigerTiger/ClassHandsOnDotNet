using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Sample
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Add(int a,int b)
        {
            int result = a + b; //result is local varible
            Console.WriteLine("Adition of {0},{1} is {2}", a, b, result);
        }
        public double Square(double n)
        {
            double result = n * n;
            return result;
        }
        public string Message(string name)
        {
            return "GoodMorning " + name;
        }
        public bool IsEven(int no)
        {
            //return no % 2 == 0 ? true : false;
            if (no % 2 == 0)
                return true;
            else
                return false;
        }
        public void Mul(int a,int b=10) //default parameter
        {
            Console.WriteLine("Multiplication of {0}*{1}={2}", a, b, (a * b));
        }
        static void Main()
        {
            Sample sample = new Sample();
            sample.Greet("Amith");
            sample.Greet("Renuka");
            sample.Add(12, 23);
            sample.Add(34, 45);
            double result= sample.Square(12);
            Console.WriteLine(result);
            string message=sample.Message("Sachin");
            Console.WriteLine(message);
            Console.WriteLine("Enter a no");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine(sample.IsEven(no)?"Even":"Odd");
            sample.Add(a: 5, b: 4); //named parametes
            sample.Greet(name: "Rohith");
            sample.Mul(10); //b as 10
            sample.Mul(4, 7);
            Console.ReadKey();
        }
    }
}
