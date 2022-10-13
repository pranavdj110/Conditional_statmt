using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q7Listcol
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            List<int> l = new List<int>();
            l.Add(100);
            l.Add(200);
            l.Add(300);
            l.AddRange(arr);
            foreach (int i in l)
                Console.WriteLine(i);

        }
    }
}
