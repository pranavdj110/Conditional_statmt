using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Inheritance
{
    class Sports                     //Multilevel Inheritance
    {
        internal int players;
        internal int no_of_umpires;
        

    }
    class Cricket : Sports
    {
        int no_of_batsman;
       protected int teams,no_of_innings;
       protected float overs = 50;
        float runs = 310;
        float Run_rate;
        public void Runrate()
        {
            Run_rate = runs / overs;
            Console.WriteLine("Run Rate=" + Run_rate);
        }
    }

    class T20 : Cricket
    {
        public void T20Info()
        {
            overs = 20;
            teams = 2;
            no_of_innings = 2;
            Console.WriteLine("No of Overs in t20:" + overs);
            
        }
        
    }

    class Program
    {
        static void Main(String[] args)
        {
          Cricket ct = new Cricket();
             

            T20 t = new T20();
            t.T20Info();
            Console.Write("Runrate for ODI:");
            t.Runrate();
            Console.WriteLine();
            Console.Write("Runrate for T20:");
            ct.Runrate();

        }
    }
   
}
