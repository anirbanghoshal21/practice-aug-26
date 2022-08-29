using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q2_Array_class;

namespace Q2_Array_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[2];
            for (int i = 0; i < stu.Length; i++)
            {
                stu[i] = new Student();
                Console.WriteLine("Enter rollno");
                stu[i].rollno= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter sname");
                stu[i].StuName=Console.ReadLine();
                Console.WriteLine("Enter Marks");
                stu[i].marks=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter City");
                stu[i].City = Console.ReadLine();

            }
            foreach (var item in stu)
            {
                Console.WriteLine("Following are the details");
                Console.WriteLine(item.rollno);
                Console.WriteLine(item.StuName);
                Console.WriteLine(item.marks);
                Console.WriteLine(item.City);
                
            }
            Console.ReadLine();
        }
    }
}
