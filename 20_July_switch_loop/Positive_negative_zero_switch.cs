using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class Positive_negative_zero_switch
    {
        static void Main(String[] args)
        {
            int num,num2;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());
            num2 = -num;
            int result = num / num2;    

            switch(result)
            {
                case 1:Console.WriteLine("POsitive");          
                    break;
                case -1: Console.WriteLine("Negative");
                    break;
                case 0: Console.WriteLine("Zero");
                    break;
            }
        }
    }
}
