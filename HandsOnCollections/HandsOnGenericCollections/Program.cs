using System;

namespace HandsOnGenericCollections
{
    class Test
    {
        public int a;
        public int b;
    }

    //Generic class
    class Sample<T>//generic class
    {
     //generic variables   
        public T a;
        public T b;
        public void M(T i,T j) //generic paramters
        {
            Console.WriteLine("i={0} j={1}", i, j);
        }
       //generic retrun type
        public T M1(T k)
        {
            return k;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample<int> s1 = new Sample<int>();
            s1.a = 10;
            s1.b = 20;
            s1.M(1, 3);
            s1.M1(23);
            Sample<char> s2 = new Sample<char>();
            s2.a = 'a';
            s2.b = 'c';
            s2.M1('a');
            Sample<string> s3 = new Sample<string>();
            s3.a = "Ram";
            s3.b = "Raghu";
            Sample<double> s4 = new Sample<double>();
            s4.a = 23.4;
            s4.b = 44.3;

;        }
    }
}
