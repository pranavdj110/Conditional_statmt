using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._07_SEPT_2022
{
    class Q3
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 10,4, 7, 2, 6,20 };


            int max = int.MinValue ;
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > max)
                    max = arr1[i];
            }
            // Console.WriteLine(max);

           
            int min = int.MaxValue;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                    min = arr1[i];
            }
           // Console.WriteLine(min);

            
            for(int x = min; x <= max; x++)
            {
                bool flag = true;
                for (int y = 0; y < arr1.Length; y++)
                {
                    if (x== arr1[y])
                    {
                        
                        flag = false;
                        break;
                       
                    }
                }
               if (flag==true)
                    Console.WriteLine(x);
             

            }
        }
    }
}
