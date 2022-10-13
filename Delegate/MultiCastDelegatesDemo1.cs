using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Delegate
{
    public delegate void mydel5(int a, int b);
    class Calcualtor
    {
       public void Add(int a, int b)
        {
            Console.WriteLine("Addition is: " + (a + b));
        }
        public void Substract(int a, int b)
        {
            Console.WriteLine("Substraction is is: " + (a - b));
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiplication  is: " + (a * b));
        }
    }
    class MultiCastDelegatesDemo1
    {
        static void Main(string[] args)
        {
            Calcualtor c = new Calcualtor();
            mydel5 d5 = c.Add;
            d5 = d5 + c.Substract;
            d5 = d5 + c.Multiply;
            d5(8,4);
        }
    }
}
