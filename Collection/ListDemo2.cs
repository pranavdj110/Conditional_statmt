using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class Movie:IComparable<Movie>
    {
       public string name;
       public int rating;

        public int CompareTo(Movie m)
        {
            return m.rating.CompareTo(this.rating);
        }
        public Movie(string name,int rating)
        {
            this.name = name;
            this.rating = rating;
        }

        public override string ToString()
        {
            return $"name: { name } rating:{rating} ";
        }
    }
    class ListDemo2
    {
        static void Main(String[] args)
        {
            List<Movie> m = new List<Movie>();
            m.Add(new Movie("LOTR", 9));
            m.Add(new Movie("ABC", 6));
            m.Add(new Movie("Don", 7));
            m.Sort();
            foreach (Movie a in m)
                Console.WriteLine(a);

        }
        
    }

    

}
