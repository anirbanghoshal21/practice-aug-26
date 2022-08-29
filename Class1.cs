using Q1_Array_structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_Array_structure
{
    public struct student
    {
        public int Id;
        public string Name;
        public int Fees;

        public void SetStudent(int id, string name, int fees)
        {
            Id = id;
            Name = name;
            Fees = fees;
        }
        public void PrintStudent()
        {
            Console.WriteLine("Student details:");
            Console.WriteLine("\tID     : " + Id);
            Console.WriteLine("\tName   : " + Name);
            Console.WriteLine("\tFees   : " + Fees);
            Console.WriteLine("\n");
        }
        }
}
class Class1
{
    static void Main(string[] args)
    {
        student[] S = { new student(), new student() };
        S[0].SetStudent(101, "Rohit", 5000);
        S[1].SetStudent(102, "Virat", 8000);

        S[0].PrintStudent();
        S[1].PrintStudent();

        Console.ReadKey();
    }
}
