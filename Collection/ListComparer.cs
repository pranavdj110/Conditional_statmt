using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class MysortStringBuilder : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder sb1,StringBuilder sb2)
        {
            string s1 = sb1.ToString();
            string s2 = sb2.ToString();

            return s2.CompareTo(s1);
        }
    }
    class ListComparer
    {
        static void Main(string[] args)
        {
            List<StringBuilder> lst = new List<StringBuilder>();
            lst.Add(new StringBuilder("Radha"));
            lst.Add(new StringBuilder("Bhagirathi"));
            lst.Add(new StringBuilder("Sanvika"));
            lst.Add(new StringBuilder("Chitralekha"));
            lst.Add(new StringBuilder("Snehprabha"));
            lst.Sort(new MysortStringBuilder());
            foreach (StringBuilder ob in lst)
                Console.WriteLine(ob);

        }
    }
}
