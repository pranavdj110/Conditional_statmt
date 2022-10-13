using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Loop_print_tableof_number
    {
        static void Main(String[] args)
        {
            int num;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());

            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num * i);
            }
        }
    }
}
