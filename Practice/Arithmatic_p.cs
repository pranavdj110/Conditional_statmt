using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Practice
{
    class Arithmatic_p
    {
        static void Main(String[] args)
        {
            int n = 19;                         //req term nth term=19th term

            int num = 22;
            int num1 = 24;
            int d;


            if (num1 > num)
                d = num1 - num;
            else
                d = num - num1;

           
            while (num1 >= 0)
            {
                num1 = num1 - d;
            }
            
               
            int a = num1 + d;                    //first term    
            Console.WriteLine(a);


            int req_num = a + (n - 1) * d;
            Console.WriteLine("nth term:" + req_num);
            
            
            
            
              
           

          
        }

        
    }
}
