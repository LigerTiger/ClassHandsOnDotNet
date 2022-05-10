using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.HandsOnConditionalStatements
{
    class Demo01
    {
        static void Main()
        {
            Console.WriteLine("Enter no");
            int no = int.Parse(Console.ReadLine());
            if (no % 2 == 0)
                Console.WriteLine("{0} is Even", no);
            else
                Console.WriteLine("{0} is Odd", no);
            Console.ReadKey();
        }
    }
}
