using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace HandsOnExceptions
{
    class Demo1
    {
        //nested try-catch
        static void Main()
        {
            try
            {
                try
                {

                    int[] a = { 12, 23, 34, 45 };
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.WriteLine(a[i]);
                    }
                    int k = a[2] / 0;
                }
                catch (IndexOutOfRangeException ex)
                {

                    Console.WriteLine(ex.Message);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); //ex is Excetion object
               
            }
            Console.ReadKey();
        }
    }
}
