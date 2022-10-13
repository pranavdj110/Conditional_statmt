using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q07     //Program to remove duplicate numbers
    {
        static void Main(String[] args)
        {
            int[] ch = {2,6,7,8,9,2,7};
            Console.WriteLine(string.Join(" ", ch));
            for (int i = 0; i < ch.Length; i++)
            {
                bool isTrue = true;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (ch[i] == ch[k])
                    {

                        isTrue = false;
                        break;
                    }
                }
                if (isTrue == true)
                {
                    int count = 0;
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[i] == ch[j])
                        {
                            count++;
                        }

                    }
                    
                    
                        Console.Write(ch[i]+" ");
                    

                }

            }
        }
    }
}
