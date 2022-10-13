using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week1_exam_30July
{
    class Base_index
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Base number:");
           int base1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Index number:");
            int index = int.Parse(Console.ReadLine());
            int temp = 1;
            for(int i=index;i>=1;i--)
            {
                temp = temp * base1;
              
            }
            Console.WriteLine(temp);
        }
    }
}
