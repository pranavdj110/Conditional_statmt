using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q11DictCol
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Chitralekha");
            d.Add(2, "Bhagirathi");
            d.Add(3, "Rajeshwari");
            d.Add(4, "Lakshmibai");

            foreach (KeyValuePair<int, string> kv in d)
                Console.WriteLine(kv.Key + " "+kv.Value);

            Dictionary<string, int> dct = new Dictionary<string, int>();
            dct.Add("Virat", 99);
            dct.Add("Rohit", 43);
            dct.Add("Sachin", 10);


            foreach (KeyValuePair<string, int> kv in dct)
                Console.WriteLine(kv.Key + " " + kv.Value);
        }
    }
}
