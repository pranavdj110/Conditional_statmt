using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class StackDemo1
    {
        static void Main(string[] args)
        {
            Stack<string> name = new Stack<string>();
            name.Push("Rahul");
            name.Push("Virat");
            name.Push("Sachin");
            name.Push("Anil");

            foreach (string s in name)
                Console.WriteLine(s);

            string s1=name.Pop();
            Console.WriteLine("Poped Element:" + s1);

            foreach (string s in name)
                Console.WriteLine(s);

        }
    }
}
