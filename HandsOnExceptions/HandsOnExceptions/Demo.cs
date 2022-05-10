using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    internal class Demo
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
            catch (DivideByZeroException ex)
            {
                // Console.WriteLine(ex.Message);
                Console.WriteLine("b value should not be 0");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("values between 1 to 255");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetBaseException().Message);
            }
            //catch
            //{
            //    Console.WriteLine("Error Occured...");
            //}
        }
        static void Main()
        {
            //Div(12, 3);
            //Div(12, 0);
            string a, b;
            Console.WriteLine("Enter a, b values");
            a = Console.ReadLine();
            b = Console.ReadLine();
            Div(a, b);
            Console.ReadKey();
        }
    }
}
