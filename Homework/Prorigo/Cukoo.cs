using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework.Prorigo
{
    class Cukoo
    {
        static int Cooko(int s)
        {
            int c = 0;
            if (s == 1)
            {
                return 0;
            }
            else if (s == 2)
            {
                return 1;
            }
            else
            {
                c = 1 * Cooko(s - 1) + 2 * Cooko(s - 2) + 3 * 1;
                return c;
            }
        }
        static void Main(String[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int d = Cooko(a);
            Console.WriteLine(d);
        }
    }
}
