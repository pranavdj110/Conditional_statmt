using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class CollectionDemo1
    {
        static void Main(String[] args)
        {
            List<string> lst = new List<string>();
            Console.WriteLine(lst.Capacity);
            Console.WriteLine(lst.Count);
            lst.Add("pranav");
            lst.Add("om");
            lst.Add("ram");
            lst.Add("shyam");
            lst.Add("raj");
            Console.WriteLine(lst);
            Console.WriteLine(lst.Capacity);
            Console.WriteLine(lst.Count);
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i]);
            }
            Console.WriteLine();
            Console.WriteLine(lst.Capacity);
            Console.WriteLine(lst.Count);
            lst.Insert(4, "vishal");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.Write(lst[i]);
            }
            Console.WriteLine(lst[3]);

            Console.WriteLine(lst.IndexOf("pranav"));
            Console.WriteLine(lst.LastIndexOf("pranavl"));
            Console.WriteLine(lst.Contains("ram"));

        }
       
         
    }
}
