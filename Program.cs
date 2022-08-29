using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Q3_Product;

namespace Q3_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product1> list = new List<Product1>();

            Console.WriteLine("Enter no of products to be added:");
            int n = int.Parse(Console.ReadLine());
            //Add products
            for (int i = 0; i < n; i++)
            {
                //Addproduct(list);
            }

            displaylist(list);

            //Removeproducts
            Removeproduct(list);

            displaylist(list);

        }
        private static void Removeproduct(List<Product1> list)
        {
            Console.WriteLine("Enter prodId to be deleted");
            int id = int.Parse(Console.ReadLine());

            Product1 r = list.Find(s => s.ProdId == id);
            Console.WriteLine($"Removed successfully:{list.Remove(r)}");

        }

        private static void displaylist(List<Product1> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item.ProdName);
                Console.WriteLine(item.ProdId);
                Console.WriteLine("--------------------");

                

            }

            
        }
        {
        private static void AddProduct(List<Product1> list)
        {
            Product1 r1 = new Product1();

            Console.WriteLine("Enter prodId to be added");
            int id = int.Parse(Console.ReadLine());

            Product1 r1 = list.Find(s => s.ProdId == id);
            Console.WriteLine($"Added successfully:{list.Add(r)}");
        }
    }
}
