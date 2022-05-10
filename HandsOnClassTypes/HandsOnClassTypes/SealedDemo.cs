using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class A
    {
        public void M() { }
    }
   sealed class B : A
    {
        public void M1() { }
    }
    //class C:B //Sealed classes are not inherited
    //{

    //}
    class SealedDemo
    {
        static void Main()
        {
            B b = new B(); //sealed classes are instantiated
            b.M();
            b.M1();
        }
    }
}
