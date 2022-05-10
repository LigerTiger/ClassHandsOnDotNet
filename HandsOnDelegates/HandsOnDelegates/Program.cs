using System;

namespace HandsOnDelegates
{
    //delegate declaration
    public delegate void MyDelegate();
    class Sample
    {
        public void Task()
        {
            Console.WriteLine("Task is Running..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample();
            //instantiate delegate
            MyDelegate delObj = new MyDelegate(s1.Task); //refer Task method by delegate object
            //calling delegate
            delObj(); //invoking delegate
        }
    }
}
