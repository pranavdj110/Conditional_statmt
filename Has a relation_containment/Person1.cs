using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Has_a_relation_containment
{
    class Address1
    {
        string city;
        int pincode;
         
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public int Pincode
        {
            get
            {
                return pincode;
            }
            set
            {
                pincode = value;
            }
        }

    }
    class Person1
    {
        int id;
        string name;
        Address1 adr;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
        public Address1 Adr
        {
            get
            {
                return adr;
            }
            set
            {
                adr = value;
            }
        }
    }

    class PersonInfo
    {
        static void Main(String[] args)
        {
            Person1 pr = new Person1();
            pr.Id = 101;
            pr.Name = "Ram";
            pr.Adr = new Address1();
            pr.Adr.City = "Delhi";
            pr.Adr.Pincode = 123456;

            Console.WriteLine(pr.Id + " " + pr.Name + " " + pr.Adr.City + " " + pr.Adr.Pincode);
        }
    }
}
