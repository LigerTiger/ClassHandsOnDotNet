using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverriding
{
    class Test { }
    class Sample
    {
        private string name;

        public Sample(string name)
        {
            this.name = name;
        }
        public override string ToString() //re-definig 
        {
            return "Hello " + name;
        }
    }
    internal class Demo4
    {
        public static void Main()
        {
            Test t = new Test();
         
            Console.WriteLine(t.ToString());
            Sample s = new Sample("Ankith");
            Console.WriteLine(s.ToString());
            Console.ReadKey();
        }
    }
}
