using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class Books
    {
        string bname;
        string author;
        int price;

        public Books(string bname, string author, int price)
        {
            this.bname = bname;
            this.author = author;
            this.price = price;
        }

        public string Bname { get => bname; set => bname = value; }
        public string Author { get => author; set => author = value; }
        public int Price { get => price; set => price = value; }

        public override string ToString()
        {
            return $"Book Name:{bname} Author:{author} Price{price}";
        }
    }
    class SortedBookPrice:IComparer<Books>
    {
        public int Compare(Books x,Books y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }
    /*class SortedListDemo3
    {
        static void Main(string[] args)
        {
            SortedList<Books, int> sl = new SortedList<Books, int>(new SortedBookPrice());
            sl.Add(new Books("Csharp", "Ricky",500),4);
            sl.Add(new Books("Python", "Andrew",200), 4);
            sl.Add(new Books("Java",  "James",750), 5);
            sl.Add(new Books("SQL", "David",300), 2);

            foreach (KeyValuePair<Books, int> kv in sl)
                Console.WriteLine(kv.Key + "--->" + kv.Value);

        }
    }*/
    class SortedDictionaryDemo
    {
        static void Main(string[] args)
        {
            SortedDictionary<Books, int> s1 = new SortedDictionary<Books, int>(new SortedBookPrice());
            s1.Add(new Books("Csharp", "Ricky", 500), 4);
            s1.Add(new Books("Python", "Andrew", 200), 4);
            s1.Add(new Books("Java", "James", 750), 5);
            s1.Add(new Books("SQL", "David", 300), 2);

            foreach (KeyValuePair<Books, int> kv in s1)
                Console.WriteLine(kv.Key + "--->" + kv.Value);
        }
    }
}
