using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Polymorphism
{
    class Loan
    {
        double total1, total2;
        int p = 10000, n = 4;
        
          
        public void Calculate_loan(float f1)
        {
            total1 = p * n * f1 / 100;
            Console.WriteLine("Laon with one interest rate:" + total1);
        }
    

        public void Calculate_loan(float f1, float f2)
        {

            if (n < 6)
            {
                total2 = p * n * f1 / 100;

            }
            else

            {
                total2 = (p * f1 * 6 / 100) + (p * f2 * (n - 6) / 100);
                Console.WriteLine("Laon with two interest rates:" + total2);
            }


        }
    
        static void Main(String[] args)
        {
            Loan l1 = new Loan();
           
            l1.Calculate_loan(5);
            l1.Calculate_loan(5, 10);

        }
    }
    
   
}
