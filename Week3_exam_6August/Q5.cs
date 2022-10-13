using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week3_exam_6August
{
    class Q5
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Country:");
            Console.WriteLine("India,China,Bangladesh,Ialy,USA");
            string str = Console.ReadLine();

            switch (str)
            {
                case "India":Console.WriteLine("Hockey");
                    break;
                case "China":
                    Console.WriteLine("Table tennis");
                    break;
                case "Bangladesh":
                    Console.WriteLine("Kabbadi");
                    break;
                case "Italy":
                    Console.WriteLine("Football");
                    break;
                case "USA":
                    Console.WriteLine("Baseball");
                    break;

            }


        }
    }
}
