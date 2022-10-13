using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.OOPs
{
    class Car
    {
        string brand;
        string model_name;
        string engine;
        int no_of_seats;
        int wheels;
        string color;


        static void Main(String[] args)
        {
            Car A7 = new Car();
            A7.brand = "Audi";
            A7.model_name = "A7";
            A7.engine = "ENG2000HP";
            A7.no_of_seats = 2;
            A7.wheels = 4;
            A7.color = "White";
            Console.WriteLine(A7.brand);
            Console.WriteLine(A7.model_name);
            Console.WriteLine(A7.engine);
            Console.WriteLine(A7.no_of_seats);
            Console.WriteLine(A7.wheels);
            Console.WriteLine(A7.color);


            Car D730 = new Car();
            D730.brand = "BMW";
            D730.model_name = "730d";
            D730.engine = "ENG2100HP";
            D730.no_of_seats = 4;
            D730.wheels = 4;
            D730.color = "Silver";
            Console.WriteLine(D730.brand);
            Console.WriteLine(D730.model_name);
            Console.WriteLine(D730.engine);
            Console.WriteLine(D730.no_of_seats);
            Console.WriteLine(D730.wheels);
            Console.WriteLine(D730.color);

            Car xj = new Car();
            xj.brand = "Jaguar";
            xj.model_name = "xj50";
            xj.engine = "ENG1900HP";
            xj.no_of_seats = 4;
            xj.wheels = 4;
            xj.color = "White";
            Console.WriteLine(xj.brand);
            Console.WriteLine(xj.model_name);
            Console.WriteLine(xj.engine);
            Console.WriteLine(xj.no_of_seats);
            Console.WriteLine(xj.wheels);
            Console.WriteLine(xj.color);

            Car evoque = new Car();
            evoque.brand = "RangeRover";
            evoque.model_name = "evoque";
            evoque.engine = "ENG1500HP";
            evoque.no_of_seats = 4;
            evoque.wheels = 4;
            evoque.color = "Red";
            Console.WriteLine(evoque.brand);
            Console.WriteLine(evoque.model_name);
            Console.WriteLine(evoque.engine);
            Console.WriteLine(evoque.no_of_seats);
            Console.WriteLine(evoque.wheels);
            Console.WriteLine(evoque.color);






        }
    }
}
