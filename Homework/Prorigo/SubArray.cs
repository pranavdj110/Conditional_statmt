using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework.Prorigo
{
    class SubArray
    {
        public  int Large_subArey(int[] arr)
        {
            int max = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                int z = 0, one = 0;
                for(int j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 1)
                    {
                        one++;
                    }
                    else
                    {
                        z++;
                    }
                    if (z == one)
                    {
                        if (max < (j - i + 1))
                        {
                            max = j - i + 1;
                        }
                    }
                }
            }
            return max;
        }

        static void Main(String[] args)
        {
            int[] arr1 = { 1, 1, 0, 0, 1, 0, 1, 1, 0, 0 };
            SubArray sb = new SubArray();
            int max = sb.Large_subArey(arr1);
            Console.WriteLine(max);
        }
    }
}
