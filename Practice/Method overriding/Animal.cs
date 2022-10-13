using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice.Method_overriding
{
    class Animal
    {
        public Animal(int a)
        {
            Console.WriteLine(a);
            Console.WriteLine("Hello Animal");
        }
        public void Move()
        {
            Console.WriteLine("Walk");
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }

        
    }
    class Cat : Animal
    {
        public Cat(int i):base(i)
        {
            Console.WriteLine("Hello Cat");
        }
        public override void Sound()
        {
           // base.Sound();
            Console.WriteLine("meow");
        }
    }

    class OverridingDemo
    {
        static void Main(String[] args)
        {
            Animal a = new Cat(8);
           // Animal a = new Animal();
          //  Cat c = new Cat();
          //  c.Sound();

            a.Sound();
        }
    }
}
