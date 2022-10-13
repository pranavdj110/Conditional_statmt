using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace Conditional_statmt.Collection
{
    class LinkedListDemo1
    {
        static void Main(string[] args)
        {
            LinkedList<int> l1 = new LinkedList<int>();
            l1.AddFirst(20);
            l1.AddLast(40);
            l1.AddLast(50);
            l1.AddLast(2);

            LinkedListNode<int> node = l1.Find(40);
            if (node != null)
                l1.AddBefore(node, 1000);

            foreach (int data in l1)
                Console.WriteLine(data);

            //for (int i = 0; i < l1.Count; i++)
                //Console.WriteLine(l1.ElementAt(i));
        }
    }
}
