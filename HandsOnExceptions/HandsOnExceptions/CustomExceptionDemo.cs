using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    internal class CustomExceptionDemo
    {
        static void Main()
        {
            Console.WriteLine("Enter Age");
            try
            {
                int age = int.Parse(Console.ReadLine());
                if (age < 18 || age > 34)
                {
                    throw new AgeException(age+"is Invalid\n Registration Failed");
                    //throw new AgeException();
                }
                else
                    Console.WriteLine("Registration Success.");
            }
            catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
