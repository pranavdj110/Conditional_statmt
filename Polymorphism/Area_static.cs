using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Polymorphism
{
   public class Area_static
    {
        static double area;
        static void Cal_Area(int r)
        {
            area = 3.14 * r * r;
            Console.WriteLine("Area of circle:"+area);
        }

        static void Cal_Area(int b,int l)
        {
            area = b * l;
            Console.WriteLine("Area of Rectangle:" + area);
        }
        static void Cal_Area(float s)
        {
            area = s * s;
            Console.WriteLine("Area of Square:" + area);
        }

        static void Main(String[] args)
        {
            Area_static.Cal_Area(5f);
            Area_static.Cal_Area(5);
            Area_static.Cal_Area(4,5);
        }

    }

    
}
