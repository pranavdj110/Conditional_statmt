using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._24_Aug_2022
{
    class Program4       //Occurance of each character in string
    {
        static void Main(String[] args) 
        { 
              string str = "pranav";
            
            
            
            Console.WriteLine("string:" + str);
            for (int i = 0; i < str.Length; i++)
            {
                bool isTrue = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (str[i] == str[k])
                    {

                        isTrue = false;
                        break;
                    }
                }
                if (isTrue == true)
                {
                    int count = 1;
                    for (int j = i + 1; j < str.Length; j++)
                    {
                        if (str[i] == str[j])
                        {
                            count++;
                        }

                    }
                    Console.WriteLine("Occurance of " + str[i] + " is: " + count);
                    
                }
           
            }  
        }
    }
}
