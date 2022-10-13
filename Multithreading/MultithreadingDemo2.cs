using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Conditional_statmt.Multithreading
{
    class MultithreadingDemo2
    {
        static void M2()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Child:" + i);
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts:");
            Thread t1 = new Thread(M2);
            t1.Start();
            Thread t2 = new Thread(M2);
            t2.Start();
            t1.Join();
            t2.Join();
            for(int j = 1; j <= 20; j = j + 2)
            {
                Console.WriteLine(j);
            }
        }
    }
}
