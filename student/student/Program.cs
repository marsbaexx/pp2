using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string last;
            double gpa;
            name = Console.ReadLine();
            last = Console.ReadLine();
            gpa = double.Parse(Console.ReadLine());
            Student1 studentt = new Student1(name, last, gpa);
            Console.WriteLine(studentt);
            Console.ReadKey();
        }
    }
}
