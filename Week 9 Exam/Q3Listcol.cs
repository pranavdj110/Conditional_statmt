using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q3Listcol
    {
        static void Main(string[] args)
        {
            List<string> color = new List<string>();
            color.Add("Yellow");
            color.Add("Blue");
            color.Add("Green");
            color.Add("Orange");
            foreach (string s in color)
                Console.WriteLine(s);

        }
    }
}
