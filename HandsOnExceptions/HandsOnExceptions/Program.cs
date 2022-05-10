using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Program
    {
       public static void Main()
        {
            Console.WriteLine("Enter a,b values");

           
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine("Division:"+c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("b value should not be zero");
                Console.WriteLine(ex.Message);  
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Enter only no's");
            }
            Console.ReadKey();
        }
    }
}
