using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDoubts
{
    class Demo1
    {
        static void Main()
        {
            double d = 915;
            double amt = 100;
            double a = (d+d / 100 * 1.5) - amt;
            Console.WriteLine(a);
        }
    }
}
