using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Polymorphism
{
    class Area
    {
        
        double area;
        public void Cal_Area(int r)
        {
            //this.r = r;
             area = 3.14 * r * r;
           this.Display();
        }

        public void Cal_Area(double side)
        {
            area = side * side;
            this.Display();
        }

        public void Cal_Area(int base1, int height1)
        {
            area = 0.50 * base1 * height1;
            this.Display();
        }

        public void Cal_Area(double breadth, int height )
        {
            area = breadth * height;
            this.Display();
        }


        public void Display()
        {
            Console.WriteLine("Area is:" + area);
        }



        static void Main(String[] args)
        {
            Area a1 = new Area();
            a1.Cal_Area(4);
            a1.Cal_Area(4.5, 10);
            a1.Cal_Area(4, 8);
            a1.Cal_Area(5.5);

        }


    }
}
