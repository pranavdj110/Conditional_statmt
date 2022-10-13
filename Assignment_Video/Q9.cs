using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q9
    {
        static void Main(String[] args)
        {
            int num=4909;
            int t2000,d500,d200,d100,d50,d20,d10,d1,t1,t2,t3,t4,t5,t6,t7,t8;
            if(num >2000)
            {
               t2000= num / 2000;
                t1 = num % 2000;
                if(t1==0)
                {
                    Console.WriteLine("2000 denomination=" + t2000);
                }
                else if(t1>=500||t1<=999)
                {
                    Console.WriteLine("2000 denomination=" + t2000);
                    d500 = t1 / 500;
                     t2 = t1 % 500;
                    if(t2==0)
                    {
                        Console.WriteLine("500 denomination=" + d500);
                    }
                    else if(t2<=499&&t2>=200)
                    {
                        Console.WriteLine("500 denomination=" + d500);
                        d200 = t2 / 200;
                         t3 = t2 % 200;
                        if (t3 == 0)
                        {
                            Console.WriteLine("200 denomination=" + d200);
                        }
                        else if(t3>=100&&t3<=199)
                        {
                            Console.WriteLine("500 denomination=" + d200);
                            d100 = t3 / 100;
                            t4 = t3 % 100;
                            if(t4==0)
                            {
                                Console.WriteLine("200 denomination=" + d100);
                            }
                            else if(t4>=50&&t4<=99)
                            {
                                Console.WriteLine("200 denomination=" + d100);
                                d50 = t4 / 50;
                                t5 = t4 % 50;
                                if(t5==0)
                                {
                                    Console.WriteLine("50 denomination=" + d50);
                                }
                                else if(t5>20&&t5<=49)
                                {
                                    Console.WriteLine("50 denomination=" + d50);
                                    d20 = t5 / 20;
                                    t6 = t5 % 20;
                                    if(t6==0)
                                    {
                                        Console.WriteLine("20 denomination=" + d20);

                                    }
                                    else if(t6 >= 10 && t6 <= 19)
                                    {
                                        Console.WriteLine("20 denomination=" + d20);
                                        d10 = t6 / 10;
                                        t7 = t6 % 10;
                                        if (t7 == 0)
                                        {
                                            Console.WriteLine("10 denomination=" + d10);
                                        }
                                        else if(t7<10)
                                        {
                                            Console.WriteLine("10 denomination=" + d10);
                                            d1 = t7 / 1;
                                            Console.WriteLine("1 denomination=" + d1);
                                        }
                                    }

                                }

                            }

                        }

                    }

                }
            }
           // Console.WriteLine(1200 / 500);
        }
    }
}
