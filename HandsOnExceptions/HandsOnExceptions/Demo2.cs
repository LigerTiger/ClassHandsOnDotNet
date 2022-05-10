using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptions
{
    class Demo2
    {
        public static void Greet(string name)
        {
            try
            {
                if (name == null)
                    throw new NullReferenceException("Name should not be null");
                string mesg= "Hello " + name.ToUpper();
               Console.WriteLine(mesg);
            }
            catch(NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
               
            }
            finally
            {
                //Cleanup code
                Console.WriteLine("Task is Closed..");
            }
            
        }
        static void Main()
        {
            try
            {
                string s = "Amith";
                Greet(s);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
