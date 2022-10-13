using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Delegate
{
    public delegate void mydel2();
    public delegate string mydel3(string s);
    public delegate bool mydel4(int n);
    class Greetings
    {
        public void Greet()
        {
            Console.WriteLine("Good morning");
        }

        public string Greet(string str)
        {
            return str+"Have a nice day";
        }

        public bool Iseven(int n)
        {
            if (n % 2 == 0)
                return true;
            else
                return false;
        }
    }

    class DelegateDemo2
    {
        static void Main(string[] args)
        {
            Greetings gr = new Greetings();
            mydel2 d2 = gr.Greet;
            d2();
            mydel3 d3 = gr.Greet;
            string str = d3("Good morning");
            Console.WriteLine(str);

            mydel4 d4 = gr.Iseven;
            bool b=d4(8);
            Console.WriteLine(b);
        }
    }
}
