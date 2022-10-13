using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt
{
    class Marks_Grade
    {
        static void Main(string[] args)
        {
            int mathematics = 90;
            int marathi = 85;
            int english = 80;
            int history = 90;
            int french = 95;
            int sum;
            double percent;
            sum = mathematics + marathi + english + history + french;
            percent = sum / 500 * 100;
            if (percent >= 70)
            {
                Console.WriteLine("Distinction");
            }
            else if (percent >= 60 && percent <= 69)
            {
                Console.WriteLine("First Class");
            }
            else if (percent >= 50 && percent <= 59)
            {
                Console.WriteLine("Second Class");
            }
            else if (percent >= 35 && percent <= 49)
            {
                Console.WriteLine("Pass");
            }
            else if (percent < 35)
            {
                Console.WriteLine("Fail");
            }

        }
    }
}
