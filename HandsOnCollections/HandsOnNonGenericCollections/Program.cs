using System;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            //addig values to arraylist
            list.Add(10);
            list.Add(23);
            list.Add(35);
            list.Insert(0, 100); //add item using index
            //access the value
            int k = Convert.ToInt32(list[1]); //convert object into int
            //display all the values
            foreach (var item in list)
                Console.WriteLine(item);
            //remove item
            list.Remove(35); //25 is removed
            list.RemoveAt(2); ; //value at 2nd index removed
            Console.WriteLine("no of Items:{0} ", list.Count); //Count retruns no of items in the list
           
            if (list.Contains(35))
            {
                Console.WriteLine("item is there");
            }
            else
                Console.WriteLine("wrong item.");
            list.Sort(); //sort list elements
            list.Reverse(); //reverse list elements
            Console.ReadKey();
        }
    }
}
