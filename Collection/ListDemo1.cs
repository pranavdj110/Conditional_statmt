using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class Book:IComparable<Book>
    {
        string book_name;
        int price;
        string Author_name;
        public int CompareTo(Book b2)
        {
            // return this.price.CompareTo(b2.price);

            if (this.price == b2.price)
            {
                return this.Author_name.CompareTo(b2.Author_name);
            }
            return this.price.CompareTo(b2.price);
        }

        public Book(string book_name, int price, string Author_name)
        {
            this.book_name = book_name;
            this.price = price;
            this.Author_name = Author_name;
        }
        public override string ToString()
        {
            return $"Book_name: { book_name } Price:{price} Author name:{Author_name}";
        }
    }
   
}


class ListDemo1
{
    static void Main(String[] args)
    {
        /* List<Book> bk = new List<Book>();
         bk.Add(new Book("java", 500, "Kathy sierra"));
         bk.Add(new Book("Let us c", 300, "Kanetkar"));
         bk.Add(new Book("c++", 400, "Balgurusamy"));
         bk.Add(new Book("Python", 600, "Ramesh"));

     }

     List<Book> bk1 = new List<Book>()do;
 */
    }
}

