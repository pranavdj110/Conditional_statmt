using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q4Listcol
    {
        static void Main(string[] args)
        {
            List<int> i = new List<int>();
            i.Add(9);
            i.Add(59);
            i.Add(39);
            i.Add(79);

            foreach (int a in i)
                Console.WriteLine(a);

            int temp = i[3];
            i[3] = i[1];
            i[1] = temp;
            foreach (int a in i)
                Console.WriteLine(a);
            // Console.WriteLine(temp);

            i[2] = 123;                  //Q4:Replace
            foreach (int a in i)
                Console.WriteLine(a);



        }
    }
}
