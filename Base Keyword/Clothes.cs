using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Base_Keyword
{
    class Clothes                          //Use of base keyword(All three uses in a single program)
    {
       protected string color = "Yellow";
        public Clothes(string fabric1)
        {

        }
        public void Display()
        {
            Console.WriteLine(" color:" + color);
        }

    }
    class Shirt : Clothes
    {
        public string color = "White";
        public Shirt(string brand_name,string fabric):base(fabric)    //USE3:base keyword with constructor
        {

        }
        public void Display()                     //
        {
            Console.WriteLine("Shirt color:" + color);
            Console.WriteLine("Shirt color:" + base.color);
            base.Display();    //USE2:base keyword with method.
                

        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Shirt s = new Shirt("XYZ","Cotton");
            s.Display();

        }
    }
}
