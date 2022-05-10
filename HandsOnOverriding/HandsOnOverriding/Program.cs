using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOverriding
{
    abstract class Fruit
    {
        public abstract string GetColor();
    }
    class Apple : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    class Orange:Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            Console.WriteLine("Fruit Color: " + fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine("Fruit Color: " + fruit.GetColor());
        }
    }
}
