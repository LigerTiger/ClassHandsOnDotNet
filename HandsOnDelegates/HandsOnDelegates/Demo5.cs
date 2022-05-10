using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate string Delegate1();
    class Demo5
    {
        public string Greet()
        {
            return "Hello User";
        }
        public void M(Delegate1 d)
        {
            //invoiking delegate
           Console.WriteLine( d());
        }
        static void Main()
        {
            Demo5 obj = new Demo5();
            obj.M(obj.Greet); //callback methods
            obj.M(() => "Good Morning User");
        }
    }
}
