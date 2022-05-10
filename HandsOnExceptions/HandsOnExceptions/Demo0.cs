using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    internal class Demo0
    {
        public static void Div(string a, string b)
        {
            try
            {
                byte i = byte.Parse(a);
                byte j = byte.Parse(b);
                int res = i / j;
                Console.WriteLine("Result: " + res);
            }
            //It handle all the exceptions
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main()
        {
          
            string a, b;
            Console.WriteLine("Enter a, b values");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Div(a, b);
            Console.ReadKey();
        }
    }
}
