using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Conditional_statmt.Multithreading
{
    class MultithreadingDemo1
    {
        static void M1()
        {
            for(int i = 0; i <= 100; i++)
            {
                Console.WriteLine("child:" + i);
                Thread.Sleep(300);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Starts:");
            Thread t1 = new Thread(M1);
            t1.Name = "thread1";
            t1.Priority = ThreadPriority.Highest;
            t1.IsBackground = true;
            t1.Start();
            for(int i = 2; i <= 10; i = i + 2)
            {
                Console.WriteLine("main" + i);
                Thread.Sleep(200);
            }
        }
    }
}
