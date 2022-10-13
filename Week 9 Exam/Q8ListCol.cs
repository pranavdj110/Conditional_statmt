using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q8ListCol
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(100);
            l.Add(200);
            l.Add(300);
            
            foreach (int i in l)
                Console.WriteLine(i);
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Reverse List");
            l.Reverse();
            foreach (int i in l)
                Console.WriteLine(i);

        }
    }
}
