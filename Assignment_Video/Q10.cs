using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.AssignmentVideo2
{
    class Q10
    {
        static void Main(string[] args)
        {
            int num,HRA,DA;
            double Gross_salary;
            Console.WriteLine("Enter a Number:");
            num = int.Parse(Console.ReadLine());

            if(num<=10000)
            {
                HRA = 20;
                DA = 80;
                Gross_salary = (num * HRA / 100) + (num * DA / 100) + num;
                Console.WriteLine("Gross salary=" + Gross_salary);
            }
            else if (num >= 10000 && num <= 20000)
            {
                HRA = 25;
                DA = 90;
                Gross_salary = (num * HRA / 100) + (num * DA / 100) + num;
                Console.WriteLine("Gross salary=" + Gross_salary);
            }
            else if (num > 20000)
            {
                HRA = 30;
                DA = 95;
                Gross_salary = (num * HRA / 100) + (num * DA / 100) + num;
                Console.WriteLine("Gross salary=" + Gross_salary);
            }
        }
    }
}
