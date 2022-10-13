using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.OOPs
{
    class Animal
    {
        string name;
        int no_of_legs;
        string food_type;


        static void Main(String[] args)
        {
            Animal Horse = new Animal();
            Horse.name = "Horse";
            Horse.no_of_legs = 4;
            Horse.food_type = "Harbivore";
            Console.WriteLine(Horse.name);
            Console.WriteLine(Horse.no_of_legs);
            Console.WriteLine(Horse.food_type);

            Animal Lion = new Animal();
            Lion.name = "Lion";
            Lion.no_of_legs = 4;
            Lion.food_type = "Carnivore";
            Console.WriteLine(Lion.name);
            Console.WriteLine(Lion.no_of_legs);
            Console.WriteLine(Lion.food_type);

        }
    }
}
