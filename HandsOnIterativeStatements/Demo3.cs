using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.HandsOnIterativeStatements
{
    class Demo3
    {
        static void Main()
        {
            //for(int i=1;i<=100;i++)
            //{
            //    Console.Write(i+"\t");
            //}
            int i = 1;
            //for(;i<100;i++)
            //{
            //    Console.Write(i + "\t");
            //}
            //for (; i <= 100;)
            //{
            //    Console.Write(i + "\t");
            //    i++;
            //    if (i == 20)
            //        break;
            //}
            //for (; ; )
            //{
            //    Console.Write(i + "\t");
            //    i++;
            //    if (i == 10)
            //        break;
            //}
            for(;i<=100;i++)

            {
                    
                if (i % 2 == 0)
                    continue; //cancel the current iteration and more forward to next iteration
                Console.Write(i + "\t");
            }
            Console.ReadKey();
            
        }
    }
}
