using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterfaces
{
    //Multiple Inheritance
    interface IMobile
    {
        void Discount();
        void Info();
    }
    interface ILaptop
    {
        void Discount();
    }
    class ECommerce : IMobile, ILaptop
    {
        //explicit implement
        void IMobile.Discount()
        {
            Console.WriteLine("IMobile:Discount()");
        }
        void ILaptop.Discount()
        {
            Console.WriteLine("ILaptop:Discount()");
        }
        //implicit implementation
        public void Info()
        {
            Console.WriteLine("IMobile:Info()");
        }
    }
    class Demo5
    {
        static void Main()
        {
            IMobile mobile =new ECommerce();
            mobile.Discount(); //invokes the Discount() of IMobile
            mobile.Info();
            ILaptop laptop = new ECommerce();
            laptop.Discount(); //invokes the Discount() of ILaptop
        }
    }
}
