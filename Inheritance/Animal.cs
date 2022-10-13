using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Inheritance
{
    class Animal
    {
       protected string breathing;
       protected bool legs;

    }

    class Mamal:Animal
    {
     
        int no_of_legs;
        string food="Harbivore";
        public void Mamal_info()
        {
            legs = true;
            breathing = "lungs";
            Console.WriteLine("Breathing:"+breathing);
        }


    }

    class Fish : Animal
    {
        public void Fish_info()
        {
            legs = false;
            breathing = "Fin";
            Console.WriteLine("Breathing:" + breathing);
        }

    }

    class Program1
    {
        static void Main(String[] args)
        {
            Fish f = new Fish();
            Mamal m = new Mamal();
            f.Fish_info();
            m.Mamal_info();
        }
    }
}
