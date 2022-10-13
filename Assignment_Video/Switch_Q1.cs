using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Assignment_Video
{
    class Switch_Q1
    {
        static void Main(String[] args)
        {
            int r, area, perimeter, l, base1,height, s,length,breadth;
            Console.WriteLine("Select choice:");
            
            Console.WriteLine("1.Area of Circle.");
            Console.WriteLine("2.Area of triangle.");
            Console.WriteLine("3.Area of Square.");
            Console.WriteLine("4.Area of Rectangle.");
            Console.WriteLine("5.Perimeter of Circle.");
            Console.WriteLine("6.Perimeter of Square.");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 1:Console.WriteLine("Enter radius:");
                    r= int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle is:"+(r*r*3.14));
                    break;
                case 2:
                    Console.WriteLine("Enter Base:");
                     base1= int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Height:");
                    height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of circle is:" + (height *base1*0.5 ));
                    break;
                case 3:
                    Console.WriteLine("Enter Side:");
                    s = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Square is:" + (s* s));
                    break;
                case 4:
                    Console.WriteLine("Enter length:");
                    length = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter breadth:");
                    breadth = int.Parse(Console.ReadLine());
                    Console.WriteLine("Area of Rectangle is:" + (length * breadth));
                    break;
                case 5:
                    Console.WriteLine("Enter radius:");
                    r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter of circle is:" + (2 * r * 3.14));
                    break;
                case 6:
                    Console.WriteLine("Enter Side:");
                    s= int.Parse(Console.ReadLine());
                    Console.WriteLine("Perimeter of Square is:" + (4 * s));
                    break;
            }

        }
    }
}
