using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class SortedListDemo1
    {
        static void Main(string[] args)
        {

            SortedList<string, int> sl = new SortedList<string, int>();
            sl.Add("Rohit", 67);
            sl.Add("Anil", 34);
            sl.Add("Virat", 98);

            foreach (KeyValuePair<string, int> kv in sl)
                Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}
