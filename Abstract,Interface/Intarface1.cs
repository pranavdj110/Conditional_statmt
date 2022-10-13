using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Abstract_Interface
{
    interface IAddable
    {
        int Addition(int a,int b);
    }

    class Add : IAddable
    {
        int total;
        public int Addition(int a,int b)
        {
            total = a + b;
            return total;
        }
    }
    class Intarface1
    {
        public static void Main(String[] args)
        {
            Add a = new Add();
           int num= a.Addition(4, 10);
            Console.WriteLine("Addition=" + num);

        }
    }
}
