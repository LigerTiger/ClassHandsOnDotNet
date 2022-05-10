using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class StackDemo
    {
        static void Main()
        {
            Stack<int> list = new Stack<int>();
            list.Push(10);
            list.Push(23);
            list.Push(89);
            list.Push(78);
            Stack<string> list1 = new Stack<string>();
            list1.Push("Aman");
            list1.Push("Swathi");
            list1.Push("Mounika");
            Queue<char> list2 = new Queue<char>();
            list2.Enqueue('a');
            list2.Enqueue('b');
            list2.Enqueue('1');
        }
    }
}
