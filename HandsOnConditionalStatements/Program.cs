using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.HandsOnConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string s = Console.ReadLine();
            if(s=="Sachin")
            {
                Console.WriteLine("Hello " + s);
            }
        }
    }
}
