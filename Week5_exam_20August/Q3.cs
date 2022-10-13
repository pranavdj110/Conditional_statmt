using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week5_exam_20August
{
    class Q3
    {
        static void Main(String[] args)
        {
            int[] arr = { 2, 6, 7, 8, 9, 2, 7 };
            Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTrue = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr[i] == arr[k])
                    {

                        isTrue = false;
                        break;
                    }
                }
                if (isTrue == true)
                {
                    int count = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }

                    }


                    Console.WriteLine("Occurance of " + arr[i] + " is: " + count);


                }


            }
        }
    }
}
