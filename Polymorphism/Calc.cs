using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Polymorphism
{
    class Calc
    {

        double result;
        public void Calculate(int num1, int num2)
        {

            result = num1 + num2;
            this.Display();
        }
        public void Calculate(long num1, int num2)
        {

            result = num1 - num2;
            this.Display();
        }
        public void Calculate(int num1, int num2,int num3)
        {

            result = num1*num2*num3;
            this.Display();
        }
        public void Calculate(double num1, double num2)
        {

            result = num1 / num2;
            this.Display();

        }

        void Display()
        {
            Console.WriteLine("Result:" + result);
        }
       

        static void Main(String[] args)
        {
            Calc c1 = new Calc();
            c1.Calculate(8, 4);
            c1.Calculate(4.8, 2);
            c1.Calculate(10,4,2);
            c1.Calculate(90, 45);


        }



    }
}
