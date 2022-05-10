using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo7
    {
        static void Main()
        {
            Console.WriteLine("Enter Age");
            string s = Console.ReadLine();
            int i;
          // i = int.Parse(s); //exception
            int.TryParse(s, out i);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}
