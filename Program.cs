using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4_strings
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddFirst("Deepak");
            names.AddLast("Sam");
            names.AddAfter(names.First, "Ram");
            names.AddBefore(names.Last, "Avi");
            names.AddBefore(names.Last.Previous, "Kajal");
            names.AddAfter(names.First.Next, "Vaibhav");
            //LinkedListNode<String> node = names.Find("Peter");
            //names.AddBefore(node, "John");
            //names.AddAfter(node, "Lucy");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
