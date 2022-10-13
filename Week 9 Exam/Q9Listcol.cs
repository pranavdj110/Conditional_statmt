using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q9Listcol
    {
        static void Main(string[] args)
        {
            List<string> s = new List<string>();
            s.Add("Rohit");
            s.Add("Virat");
            s.Add("Shikhar");
            s.Add("Abhay");
            

            foreach (string s1 in s)
                Console.WriteLine(s1);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Sorted List:");
            s.Sort();
            foreach (string s1 in s)
                Console.WriteLine(s1);

        }
    }
}
