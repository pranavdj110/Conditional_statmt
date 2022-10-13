using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week5_exam_20August
{
    class Q1      //Program to merge two array into single array alternatively.
    {
        static void Main(String[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7,8,9 };
            int[] arr2 = { 11, 22, 33, 44 };
            int arr1_count = arr1.Length;
            int arr2_count = arr2.Length;

            int[] arr3 = new int[arr1_count + arr2_count];
                int j = 0;
            int k = 0;
            int m;
            for (int i = 0; i < arr3.Length; i++)
            {

                
                    if (i % 2 == 0)
                    {
                        arr3[i] = arr1[k];
                        k++;
                     
                    }
                    else
                    {
                        if (j != arr2.Length)
                        {
                            arr3[i] = arr2[j];
                            j++;
                        }
                    else
                    {
                        arr3[i] = arr1[k++];
                    }


                }


            }
            Console.WriteLine(string.Join(" ", arr3));
        }
    }
}
