using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Has_a_relation_containment
{
    class Pen
    {
        int length;
        string name;
        string color;
        string type;

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
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
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

    }
    class Bag
    {
        string brand_name;
        int price;
        string color;
        Pen p;

        public string Brand_name
        {
            get
            {
                return brand_name;
            }
            set
            {
                brand_name = value;
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
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Pen P
        {
            get
            {
                return p;
            }
            set
            {
                p = value;
            }
        }
    }
    class Baginfo
    {
        static void Main(String[] args)
        {
            Bag b = new Bag();
            b.Brand_name = "ABC";
            b.Price = 1000;
            b.Color = "Black";
            b.P = new Pen();
            b.P.Length = 4;
            b.P.Name = "cello";
            b.P.Color = "Yellow";
            b.P.Type = "Gel Pen";
            Console.WriteLine(b.Brand_name + " " + b.Price + " " + b.Color + " " + b.P.Length + " " + b.P.Color + " " + b.P.Type);
        }
    }
}
