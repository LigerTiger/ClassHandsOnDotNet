using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void GreetDelegate(string n);
    class Demo1
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void Main()
        {
            Demo1 obj = new Demo1();
            GreetDelegate d1 = new GreetDelegate(obj.Greet);
            d1("Sachin");

        }
    }
}
