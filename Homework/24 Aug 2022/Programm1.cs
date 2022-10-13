using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._24_Aug_2022
{
    class Programm1              //Program to remove duplicate characters
    {
        static void Main(String[] args)
        {
            string s = "shanaya";
            Console.WriteLine("Original string:" + s);
            string n = "";
            for (int i =0 ; i< s.Length; i++)
            {
                //bool b = n.Contains(s[i]);
                if (n.Contains(s[i]) == false)
                {
                    n = n + s[i];
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(n);
            
        }
    }
}
