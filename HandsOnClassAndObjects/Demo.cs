using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassAndObjects
{
    class Demo
    {
        public int Sum(int []a)
        {
            int sum = 0;
            foreach(var item in a)
            {
                sum = sum + item;
            }
            return sum;
        }
        public string[] GetFlowers()
        {
            string[] flowers = { "Rose", "Lilly", "Tulips" };
            return flowers;
        }
        static void Main()
        {
            Demo d = new Demo();
            int[] a = { 12, 23, 34, 45 };
            int result = d.Sum(a);
            Console.WriteLine("Sum of Array Numbers: " + result);
            result = d.Sum(new int[] { 23, 34, 45, 56, 67, 78 });
            Console.WriteLine("Sum of Array Numbers: " + result);
            string []f=d.GetFlowers();
            foreach (var flower in f)
                Console.WriteLine(flower);
            Console.ReadKey();
        }
    }
}
