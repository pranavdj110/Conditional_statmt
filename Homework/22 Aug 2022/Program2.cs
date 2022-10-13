using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Homework._22_Aug_2022
{
    class Program2   //name validation
    {
        static void Main(String[] args)
        {
            string name = "Abc12";
            bool isTrue = true;
            for(int i = 0; i < name.Length; i++)
            {
                if((name[i] >= 'A' && name[i] <= 'Z')|| (name[i] >= 'a' && name[i] <= 'z'))
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                    break;
                }
            }
            if (isTrue == false)
            {
                Console.WriteLine("Invalid name");
            }
            else
            {
                Console.WriteLine("Valid name");
            }
        }
    }
}
