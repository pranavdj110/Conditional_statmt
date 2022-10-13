using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class DictionaryDemo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Ram");
            dt.Add(2, "Shyam");
            dt.Add(3, "Karan");
            dt.Add(4, "Lkhan");
            dt.Add(5, "Karan");//Allowed because Values can be duplicate
            dt.Add(4, "Ganesh");//Error because key can not be duplicate

            Console.WriteLine(dt[2]);


            foreach (KeyValuePair<int, string> kv in dt)
                Console.WriteLine(kv.Key + " " + kv.Value);

        }
    }
}
