using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{

    class Order
    {
        int order_id;
        string city;
        string itemname;
        string status;

        public Order(int order_id, string city, string itemname, string status)
        {
            this.order_id = order_id;
            this.city = city;
            this.itemname = itemname;
            this.status = status;
        }

        public int Order_id { get => order_id; set => order_id = value; }
        public string City { get => city; set => city = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public string Status { get => status; set => status = value; }

        public override string ToString()
        {
            return $"Order ID:{order_id} City:{city} Item Name:{itemname} Status:{status}";
        }
    }

    
    class Q18SortedListCol
    {
        static void Main(string[] args)
        {
            List<Order> lst = new List<Order>();
            lst.Add(new Order(50012, "Mumbai", "Mobile", "Delivered"));
            lst.Add(new Order(60313, "Mumbai", "TV", "Pending"));
            lst.Add(new Order(43416, "Satara", "Mobile", "Pending"));
            lst.Add(new Order(65014, "Bhopal", "Laptop", "Delivered"));
            lst.Add(new Order(17662, "Mumbai", "Refrigerator", "Pending"));
            lst.Add(new Order(50674, "Pune", "Mouse", "Delivered"));
            lst.Add(new Order(52342, "Delhi", "Earphones", "Delivered"));
            foreach (Order od in lst)
                Console.WriteLine(od);

            SortedList<string, int> slst = new SortedList<string, int>();
            foreach(Order od1 in lst)
            {
                if (od1.Status == "Pending")
                {
                    string scity = od1.City;
                    ////Console.WriteLine(scity);

                    string Sts = od1.Status;
                    /// Console.WriteLine(Sts);
                    if (slst.ContainsKey(scity) == false)
                    {
                        slst.Add(scity, 1);
                    }
                    else
                    {
                        int val = slst[scity];
                        slst[scity] = val + 1;
                    }
                }
                


            }
            foreach (KeyValuePair<string,int> kv in slst)
                Console.WriteLine(kv.Key+ " "+kv.Value);



        }
    }
}
