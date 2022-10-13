using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.OOPs
{
    class Car_getset
    {
        int model_number;
        string name;
        int price;
        int speed;

        public int Model_number
        {
            get
            {
                return model_number;
            }
            set
            {
                model_number = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }


    class Cardetails
    {
        static void Main(String[] args)
        {
            Car_getset car1 = new Car_getset();
            car1.Model_number = 730;
            car1.Name = "BMW";
            car1.Price = 5000000;
            car1.Speed = 180;
            Console.WriteLine("Model NUmber=" + car1.Model_number +   "Car Name=" + car1.Name + "Car Price" + car1.Price + "Car Speed=" + car1.Speed);
        }
    
    }
}
