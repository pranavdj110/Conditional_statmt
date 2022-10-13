using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array13         //sort half array in Ascending order & second half array in Descending order. Date: 12 Aug 2022,Friday
    {
        static void Main(String[] args)
        {
            int[] arr = { 2, 6,1, 7, 8, 9, 3,34 };
            Console.WriteLine(string.Join(" ", arr));

            for(int i = 0; i < arr.Length / 2; i++)
            {
                int temp;
                for(int j=i+1;j< arr.Length / 2; j++) 
                { 
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                 }
                
            }
           for (int i = arr.Length / 2; i <= arr.Length ; i++)
            {
                int temp;
                for (int j = i + 1; j < arr.Length ; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
