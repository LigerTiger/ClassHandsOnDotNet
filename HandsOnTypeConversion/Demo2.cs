using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    class Demo2
    {
        static void Main()
        {
            //using Parse() method
            //Parse() method convert string to any premitive data type value
            string s = "123";
            int i = int.Parse(s); //converting string to int
            short s1 = short.Parse(s); //convert string to short
            byte b = byte.Parse(s); //convert string to byte
            double d = double.Parse(s); //convert string to double
            float f = float.Parse("234.45"); //convert string to float
            decimal dm = decimal.Parse(s); //convert string to decimal
            //i = int.Parse("ACBB"); exception
           string s11= "true";
            bool b11 = bool.Parse(s11); //convert string to bool
            string s12 = "D";
            char ch = char.Parse(s12); //convert string into char.
            Console.WriteLine(f);
            Console.WriteLine(ch);
            Console.WriteLine(i);
        }
    }
}
