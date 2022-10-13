using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework
{
    class Xobin1
    {
        float amount;
        public float Calculate(int price,int no_of_items,int profit)
        {
            amount = price * profit / 100 + price; return amount;
        }

        static void Main(String[] args)
        {
            Xobin1 x = new Xobin1();
            float sp = x.Calculate(15, 10, 20);
            Console.WriteLine(sp);
        }
    }
}
