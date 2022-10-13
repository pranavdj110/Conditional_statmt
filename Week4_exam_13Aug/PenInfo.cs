using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Nib
    {
        string material_type;
        int width;
        public string Material_Type
        {
            get
            {
                return material_type;
            }
            set
            {
                material_type = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

    }
    class Refill
    {
        string ink_color;
        int length;
        Nib nb;
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
        public string Ink_color
        {
            get
            {
                return ink_color;
            }
            set
            {
                ink_color = value;
            }
        }
        public Nib NB
        {
            get
            {
                return nb;
            }
            set
            {
                nb = value;
            }
        }

    }
    class Pen
    {
        string brand;
        int capLength;
        Refill r;
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public int CapLength
        {
            get
            {
                return capLength;
            }
            set
            {
                capLength = value;
            }
        }
        public Refill R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

    }
    
    class PenInfo
    {
        static void Main(String[] args)
        {
            Pen p = new Pen();
            p.Brand = "cello";
            p.CapLength = 2;
            p.R = new Refill();
            p.R.Ink_color = "Blue";
            p.R.Length = 4;
            p.R.NB = new Nib();
            p.R.NB.Material_Type = "Glass";
            p.R.NB.Width = 1;
            Console.WriteLine(p.Brand + " " + p.CapLength + " " + p.R.Ink_color + " " + p.R.Length + " " + p.R.NB.Material_Type + " " + p.R.NB.Width);

        }
    }
}
