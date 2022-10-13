using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Polymorphism
{
    class Mobile
    {
        int price;
        string name;
        string memory;

        public Mobile()
        {
            Console.WriteLine("I am Default.");
        }

        public Mobile(string name)
        {
            this.name = name;
            Console.WriteLine("Name:" + name);
        }

        public Mobile(int price, string memory)
        {
            this.price = price;
            this.memory = memory;
            Console.WriteLine("Price:" + price+"Memory:"+memory);
        }

        
    }
    class ConstructorOverload
    {
        static void Main(String[] args)
        {
            Mobile m = new Mobile("Apple");
            Mobile m1 = new Mobile();
            Mobile m2 = new Mobile(30000, "64GB");
        }
    }
}
