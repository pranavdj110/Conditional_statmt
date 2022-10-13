using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Inheritance
{
    class Fruit
    {
       protected string weight;
        protected string color;
        protected int price;

    }
    class Mango : Fruit
    {
        string type = "Hapus";
        
        public void MangoInfo()
        {
            price = 50;
            color = "Yellow";
            Console.WriteLine("Mango type=" + type);
            Console.WriteLine("Price=" + price);
        }
    }

    class Program2
    {
        static void Main(String[] args)
        {
            Mango m = new Mango();
            m.MangoInfo();
        }
    }
}
