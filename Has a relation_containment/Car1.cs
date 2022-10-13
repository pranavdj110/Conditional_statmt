using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Has_a_relation_containment
{
    class Engine
    {
        int engine_no;
        string engine_type;
        public Engine(int engine_no,string engine_type)
        {
            this.engine_no = engine_no;
            this.engine_type = engine_type;
        }
        public void DisplayEngine()
        {
            Console.WriteLine(engine_no+ " " + engine_type);
        }
    }
    class Car1
    {
        string name;
        string color;
        int price;
        Engine en1;
        public Car1(string name, string color, int price, Engine en1)
        {
            this.name = name;
            this.color = color;
            this.price = price;
            this.en1 = en1;
        }
        public void DisplayCar1()
        {
            Console.WriteLine(name + " " + color + " " + price);
            en1.DisplayEngine();
        }




        static void Main(String[] args)
        {
            Engine en1 = new Engine(101, "Petrol");
            Car1 c = new Car1("suzuki", "white", 100000, en1);
            c.DisplayCar1();

        }
    }
}
