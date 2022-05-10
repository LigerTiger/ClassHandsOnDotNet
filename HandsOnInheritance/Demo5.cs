using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInheritance
{
    //Multi-level Inheritance
    public class AA
    {
        public void M() { }
    }
    
    public class BB : AA
    {
        public void M1() { }
    }
    public class CC : BB
    {
        public void M2() { }
    }

    class Demo5
    {
        static void Main()
        {
            AA ob = new AA(); //no derived
            ob.M();
            BB ob1 = new BB(); //less derived
            ob1.M(); //A
            ob1.M1(); //B
            CC ob2 = new CC(); //more derived
            ob2.M(); //A
            ob2.M1(); //B
            ob2.M2(); //C
        }
    }
}
