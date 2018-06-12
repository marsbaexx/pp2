using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student
{
    class Student1
    {
        string name;
        string last;
        double gpa;

        public Student1()
        {
            name = "Name";
            last = "Last";
            gpa = 0;
        }

        public Student1(string first,string second,double ball)
        {
            name = first;
            last = second;
            gpa = ball;
        }
        public override string ToString()
        {
            return name + " " + last + " " + gpa;
        }
    }
}
