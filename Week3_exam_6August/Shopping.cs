using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week3_exam_6August
{
    class DebitCard
    {

    }
    class CreditCard
    {

    }
    class Shopping
    {
        public void doTransaction(DebitCard d)
        {
            Console.WriteLine("NO Discount on debit card transactions.");
        }
        public void doTransaction(CreditCard c)
        {
            Console.WriteLine("You got 15% discount on bill on credit card transctions.");
        }

        static void Main(String[] args)
        {
            Shopping s = new Shopping();
            DebitCard d1 = new DebitCard();
            CreditCard c1 = new CreditCard();
            s.doTransaction(c1);
            s.doTransaction(d1);
        }
    }
}
