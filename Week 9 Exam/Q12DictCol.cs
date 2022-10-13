using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Q12DictCol
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d = new Dictionary<int, string>();
            d.Add(1, "Chitralekha");
            d.Add(2, "Bhagirathi");
            d.Add(3, "Rajeshwari");
            d.Add(4, "Lakshmibai");
            Console.WriteLine("Keys are:");
            foreach (KeyValuePair<int, string> kv in d)
                Console.WriteLine(kv.Key);
        }
        
    }
}
