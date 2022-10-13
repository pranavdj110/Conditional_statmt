using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Base_Keyword
{
    class Sport
    {
        
        internal int no_of_teams;
        internal int no_of_players;
        internal int no_of_umpires;
        internal string tournament_name;

        public Sport(string tournament_name )
        {
            this.tournament_name = tournament_name;
        }

        public void Display()
        {
            Console.WriteLine("Tour name:" + tournament_name);
        }

    }
     class Cricket : Sport
    {
       
        internal int no_of_innings;
        internal float overs;
        internal int powerplay;
        internal int runs;
        internal float runrate;
        string team1,team2;
        public Cricket(string team1, string team2, string tour_name) : base(tour_name)     //base constructor
        {
            this.team1 = team1;
            this.team2 = team2;
        }
        public void Runrate(int runs,float overs)
        {
            this.runs = runs;                                   //this-variable
            this.overs = overs;
            runrate = runs / overs;
            this.Display();                                   // this-method:current instance of Display
        }
        public void Display()
        {
            base.Display();                                     //base Dispaly.
            Console.Write(team1);
            Console.Write("Vs");
            Console.WriteLine( team2);
            Console.WriteLine("Runrate is:" + runrate);
        }
    }
    class Program1
    {
        static void Main(String[] args)
        {
            Cricket cr = new Cricket("Australia", "England", "The Ashes");
            cr.Runrate(301, 47.5f);
            
        }
    }
}
