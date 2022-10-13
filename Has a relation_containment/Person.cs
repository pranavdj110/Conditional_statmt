using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Has_a_relation_containment
{

    class Address
    {
        public int pincode;
        public string city;
        public Address(int pincode,string city)
        {
            this.pincode = pincode;
            this.city = city;
        }
       public void ShowAddress()
        {
            Console.WriteLine(" " + pincode + " " + city);
        }

    }
    class Person
    {
        int id;
        string name;
        Address adr;

        Person(int id, string name,Address adr)
        {
            this.id = id;
            this.name = name;
            this.adr = adr;


        }

        void DisplayPerson()
        {
            Console.WriteLine(id + " " + name);
            adr.ShowAddress();
            
        }
        static void Main(string[] args)
        {
            /*Address a = new Address(234, "pune");
            Person p = new Person(1, "Ram", a);
            p.DisplayPerson();*/

            Person p = new Person(1, "Ram", new Address(21, "Pune"));     //Anonymous object

        }
    }
}
