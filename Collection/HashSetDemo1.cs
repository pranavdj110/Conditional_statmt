using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conditional_statmt.Collection
{
    class HashSetDemo1
    {
        static void Main(string[] args)
        {

            HashSet<string> hs = new HashSet<string>();
            hs.Add("Ram");
            hs.Add("Raj");
            hs.Add("Sita");
            hs.Add("Laxman");


            HashSet<string> hs1 = new HashSet<string>();
            hs1.Add("Ram");
            hs1.Add("Sita");
            hs1.Add("Bharat");

            /*IEnumerable<string> i = hs.IntersectWith(hs1);
            HashSet<string> h3 = i.ToHashSet();*/

            HashSet<string> h3 = hs.Intersect(hs1).ToHashSet();
            foreach (string s in h3)
                Console.WriteLine(s);
        }
    }
}
