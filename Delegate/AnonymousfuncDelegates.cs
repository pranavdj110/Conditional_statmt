using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Delegate
{
    public delegate int del6(int a, int b);
    class AnonymousfuncDelegates
    {
        static void Main(string[] args)
        {
            /*del6 d6 = delegate (int a, int b)
              {
                  Console.WriteLine("hi in Anonymous function");
                  return a * b;
              };
            int ans = d6(10, 9);
            Console.WriteLine(ans);*/

            del6 d6 = (a, b) =>
            {
                Console.WriteLine("in Lambda");
                return a * b;
            };
            int ans=d6(4, 8);
            Console.WriteLine(ans);
        }
    }
}
