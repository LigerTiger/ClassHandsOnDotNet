using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "David";
            string path = @"C:\Trainings\C#\HandsOn"; //verbatim strings
            string s1 = "GoodMorning Students";
            Console.WriteLine("Length: " + s1.Length);
            char ch = s1[1];
            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
            string s3 = "Rohan";
            string  s2 = "rohan";
            if(s2==s3)
            {
                Console.WriteLine("Strings are equal");
            }
            if (string.Compare(s2, s3) == 0)
            {
                Console.WriteLine("Strings are equal");
            }
            if (string.Compare(s2, s3,true) == 0)
            {
                Console.WriteLine("Strings are equal");
            }
            if (s2.Equals(s3))
            {
                Console.WriteLine("Strings are equal");
            }
            if (s2.Equals(s3,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Strings are equal");
            }
        }
    }
}
