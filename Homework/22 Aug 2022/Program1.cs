using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._22_Aug_2022
{
    class Program1      //Program to check whether entered password is valid or not.
    {
        static void Main(String[] args)
        {
            string pwd = "Cricket1210@gm";
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for(int i = 0; i < pwd.Length; i++)
            {
                if(pwd[i]>='A'&& pwd[i] <= 'Z')
                {
                    count1 = 1;
                }
                else if(pwd[i] >= 'a' && pwd[i] <= 'z')
                {
                    count2 = 1;
                }
                else if(pwd[i]>='0' && pwd[i] <= '9')
                {
                    count3 = 1;
                }
                else if (pwd[i] == '@' || pwd[i] == '$')
                {
                    count4 = 1;
                }
                
                count++;
            }

           // Console.WriteLine(count);
            int sum = count1 + count2 + count3 + count4;
            if (count>7 && sum == 4)
            {
                Console.WriteLine("Valid PAssword");
            }
            else
            {
                Console.WriteLine("Invalid PAssword");
            }
        }
    }
}
