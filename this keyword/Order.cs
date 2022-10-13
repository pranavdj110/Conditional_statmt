using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.this_keyword
{
    class Order
    {

       internal int order_id;
        internal string item1;
        internal int qty1;
        //internal double discount1;
        internal string item2;
        internal int qty2;
        internal string item3;
        internal int qty3;
        internal double price1=25;
        internal double price2=50;
        internal double price3=80;
        private double total;
         
        public Order(string item1,int qty1,string item2,int qty2,string item3,int qty3)
        {
            this.item1 = item1;
            this.qty1=qty1;
            this.item2 = item2;
            this.qty2 = qty2;
            this.item3 = item3;
            this.qty3 = qty3;

        }

        public void bill()
        {
            total = qty1 * price1 + qty2 * price2 + qty3 * price3;
            this.Display();
        }


        public void Display()
        {
            Console.WriteLine("Item1:" + item1 + "||Price:" + price1 + "||Quantity:" + qty1 +"||Item1_total=" +price1*qty1);
            Console.WriteLine("Item2:" + item2 + "||Price:" + price2 + "||Quantity:" + qty2 + "||Item2_total=" + price2 * qty2);
            Console.WriteLine("Item3:" + item3 + "||Price:" + price3 + "||Quantity:" + qty3 + "||Item3_total=" + price3 * qty3);
            Console.WriteLine("Total=" + total);
            //Console.WriteLine(item1+"Price:"+price1+"Quantity:"+qty1+);

        }

        static void Main(String[] args)
        {
            Order o1 = new Order("Surf excel",1,"Dark fantacy",2,"Lamp",1);
            o1.bill();
            
        }
    }
}
