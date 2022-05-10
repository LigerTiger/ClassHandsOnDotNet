using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class QueueDemo
    {
        static void Main()
        {
            //Write Demo here to exaplin Queue methods.
            Queue queue = new Queue();  
            //Add Items
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            // Pick the first item
            int k = (int)queue.Peek();
            //remove item
            queue.Dequeue(); //first item removed 1
            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
                
        }
    }
}
