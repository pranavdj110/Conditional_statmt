using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt._20_July_switch_loop
{
    class vowel_switch
    {
        static void Main(String[] args)
        {
            char ch;
            Console.WriteLine("Enter an Alphabet:");
            ch = Convert.ToChar(Console.ReadLine());
             switch(ch)
            {
                case 'a':Console.WriteLine("vowel");
                    break;
                
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                case 'A':
                    Console.WriteLine("vowel");
                    break;
                case 'E':
                    Console.WriteLine("vowel");
                    break;
                case 'I':
                    Console.WriteLine("vowel");
                    break;
                case 'O':
                    Console.WriteLine("vowel");
                    break;
                case 'U':
                    Console.WriteLine("vowel");
                    break;
                default: Console.WriteLine("Consonent");
                    break;

            }
        }
    }
}
