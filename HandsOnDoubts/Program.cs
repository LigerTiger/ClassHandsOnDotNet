using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDoubts
{
    class Program
    {
        public void Greet()
        {
            Console.WriteLine("Hello Prateek");
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 10;
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine(); //Reading values from console
            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());
            //print the given name 10 times
            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Hello " + name);
            //    i++;
            //}
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("Hello " + name);
            }
            Program obj = new Program();
            obj.Greet();
            Console.ReadKey();//Freez output window
        }
    }
}
