using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._04Aug_2022
{
    class Rectangle1
    {
        int pmeter;
        public void Perimeter(int length,int breadth)
        {
            pmeter = 2*(length + breadth);
            Console.WriteLine("Primeter of rectangle:" + pmeter);
        }
        static void Main(String[] args)
        {
            Rectangle1 r = new Rectangle1();
            r.Perimeter(4, 10);

        }
    }
}
