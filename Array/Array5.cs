using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array5                   //Display float type array elements in 3 ways: 1)for loop 2)foreach  3)string
    {
        static void Main(String[] args)
        {
            float[] f = { 1.1f, 3.2f, 6.5f, 7.5f, 9.6f };
            Console.WriteLine("Display1:");
            for (int j = 0; j <= f.Length - 1; j++)         //USING for loop
            {
                Console.WriteLine(f[j]);
            }
            Console.WriteLine("Display2:");
            foreach(float x in f)                         //USING foreach
            {
                Console.WriteLine(x);
            }
            Console.WriteLine("Display3:");
            Console.WriteLine(String.Join(" ",f));        //USING String
        }
    }
}
