using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Array
{
    class Array14      //code to find frequency of digits in an array  12 Aug 2022,Friday
    {
        static void Main(String[] args)
        {
            //int[] arr = { 2, 6, 7, 8, 9, 2, 7 };
            string arr = "dog";
            int length1 = arr.Length;
            int sum = 0;
            Console.WriteLine("First string:"+arr);
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
                     //Console.WriteLine("Occurance of "+arr[i] + " is: "+count);
                     sum = sum + count;
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine("length of string 1 is:"+length1);

            
            string arr1 = "good";
            Console.WriteLine("Second String:" + arr1);
            int length2 = arr1.Length;
            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTrue = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (arr1[i] == arr1[k])
                    {

                        isTrue = false;
                        break;
                    }
                }
                if (isTrue == true)
                {
                    int count1 = 1;
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            count1++;
                        }

                    }
                   // Console.WriteLine("Occurance of " + arr1[i] + " is: " + count1);
                    sum1 = sum1 + count1;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine("Length of string2 is:"+length2);

           
            
            if (sum == sum1 && length1==length2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
