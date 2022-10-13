using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Abstract_Interface
{
    abstract class ABC
    {
        public static int a = 4;
    }

    interface IABCable
    {
        static int b = 4;
    }

    class Child1 : ABC, IABCable
    {
        public int total = ABC.a + IABCable.b;
    }
    class interface2
    {
        static void Main(String[] args)
        {
            Child1 ch = new Child1();
            Console.WriteLine("Addition is:"+ch.total);
        }
    }
}
