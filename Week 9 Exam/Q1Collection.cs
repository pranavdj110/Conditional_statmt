using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q1Collection
    {
        static void Main(string[] args)
        {
            List<int> l1 = new List<int>();
            l1.Add(10);
            l1.Add(20);
            l1.Add(40);
            foreach (int t in l1)
                Console.WriteLine(t);

            List<string> s2 = new List<string>();
            s2.Add("Shree");
            s2.Add("Ram");
            s2.Add("Sita");
            foreach (string s in s2)
                Console.WriteLine(s);

        }
    }
}
