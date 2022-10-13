using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array8
    {
        public static void Show(int[] arr1)
        {
             int[] even=new int[10];
            int[] odd=new int[10];
            int j = 0;
            int k = 0;
            for(int i = 0; i <= arr1.Length - 1; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    even[j] = arr1[i];
                    j++;

                }
                else
                {
                    odd[k] = arr1[i];
                    k++;
                }
                
            }
            Console.WriteLine("Evens");
            Console.WriteLine(string.Join(" ",even));
            Console.WriteLine("Odds");
            Console.WriteLine(string.Join(" ", odd));

           


        }

        static void Main(String[] args)
        {
            int[] arr = { 8, 10, 9, 6, 8, 4 };
            Console.WriteLine(string.Join(" ", arr));
            /*for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }*/

            Array8.Show(arr);
        }
    }
}
