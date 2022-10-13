using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q2ListCol
    {
        static void Main(string[] args)
        {

            List<int> l = new List<int>();
            l.Add(12);
            l.Add(13);
            l.Add(1);
            l.Add(67);

            foreach (int i in l)
                Console.WriteLine(i);

            l.Insert(0, 23);
            foreach (int i in l)
                Console.WriteLine(i);

        }
    }
}
