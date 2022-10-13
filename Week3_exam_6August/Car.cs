using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week3_exam_6August
{
    class Car
    {
  string color;
        public void ChangeColor(Car c2)
        {
            c2.color = color;
            color = "Red";
        }
    }
    class Demo
    {
        static void Main(String[] args)
        {
            Car c1 = new Car();
            
        }
    }
}
