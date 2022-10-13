using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._22_Aug_2022
{
   class Sreverse
    {
        public string Reverse(string s)
    {
        string rev = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            rev = rev + s[i];
        }
        return rev;


    }
}
class Program5
{
        static void Main(String[] args)
        {
            string s = "pranav";

            Sreverse s1 = new Sreverse();
            string str2 = s1.Reverse(s);
            Console.WriteLine(str2);                              //check palindrome
            if (s == str2)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("not Palindrome");
            }
            int count_vowel = 0;
            int count_consonent = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    count_vowel++;
                }
                else
                {
                    count_consonent++;
                }
            }
            Console.WriteLine("Vowel:" + count_vowel);
            Console.WriteLine("Consonent:" + count_consonent);





            int count_a = 0;       //to count occurance of particular character
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'a')
                {
                    count_a++;
                }
            }
            Console.WriteLine("Occurance of a:" + count_a);




        }

    }
}
