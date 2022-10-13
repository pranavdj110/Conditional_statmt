using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Q3
    {
        static void Main(String[] args)
        {
            char[] ch = { 'a', 'b', 'c', 'a', 'b', 'b' };
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
                        int count = 1;
                        for (int j = i + 1; j < ch.Length; j++)
                        {
                            if (ch[i] == ch[j])
                            {
                                count++;
                            }

                        }
                    if (count == 1)
                    {
                        Console.WriteLine(ch[i] + "frequency:" + count);
                    }
                    
                }
                  
            }
        }
    }
}
