using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Delegate
{
    public delegate int mydel(int a);
    class DelegateDemo1
    {
        static int square(int x)
        {
            return x * x;
        }

        static void Main(String[] args)
        {
            mydel d = square;
            int ans = d(4);
            Console.WriteLine(ans);

        }
    }
}
