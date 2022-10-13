using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Delegate
{
    class DemoClass
    {
        public void Add()
        {
            Console.WriteLine("In Addition");
        }

        public int Mul(int a,int b)
        {
            return a * b;
        }

        public bool isLeapyear(int num)
        {
            if (num % 400 == 0)
            {

                return true;

            }
            else if (num % 100 == 0)
            {
                return false;
            }
            else if (num % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class DelegatesDemo4
    {
        static void Main(string[] args)
        {
            DemoClass dc = new DemoClass();

            Predicate<int> pr = dc.isLeapyear;
            bool b = pr(2001);
            Console.WriteLine(b);

            Func<int,int, int> fc = dc.Mul;
            int num = fc(4,8);
            Console.WriteLine(num);

            Action ac = dc.Add;
            ac();
        }
    }
}
