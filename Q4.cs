using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Product
{
    internal class Q4
    {
        public static void Main(string[] args)
        {
            var names = new LinkedList<string>();
            names.AddLast("Sonoo Jaiswal");
            names.AddLast("Ankit");
            names.AddLast("Peter");
            names.AddLast("Irfan");

            foreach (var item in names)
            {
                Console.WriteLine(names);
            }
            Console.ReadLine();
        }
    }
}
