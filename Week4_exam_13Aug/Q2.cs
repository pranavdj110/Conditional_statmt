using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q2      //predict o/p
    {
        static int mcCartyCounter = 100;
        public static int mcCarthy(int n)
        {
            mcCartyCounter++;
            if (n > 100)
                return n - 10;
            else
                return mcCarthy(n + 11);
        }
        public static void Main(String[] args)
        {
            Console.WriteLine(mcCarthy(100) + " " + mcCartyCounter);       //101,102
        }
    }
}
