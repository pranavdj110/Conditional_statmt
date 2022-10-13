using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework.Prorigo
{
    class Anagram
    {
        public bool Check_anagram(string s1,string s2)
            {
                bool isanagram = true;

                foreach (char ch in s1)
                {
                    int c1 = 0, c2 = 0;
                    foreach (char a1 in s1)
                    {
                        if (a1 == ch)
                        {
                            c1++;
                        }
                    }
                    foreach (char a2 in s2)
                    {
                        if (ch == a2)
                        {
                            c2++;
                        }
                    }
                    if (c1 != c2)
                    {
                        isanagram = false;
                        break;
                    }
                }
                return isanagram;
            }
        static void Main(String[] args)
        {
            string s1 = "good";
            string s2 = "dog";
            Anagram an = new Anagram();
            bool bn = an.Check_anagram(s1, s2);
            if(bn==true)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not Anagram");
            }
        }
     }
    
}
