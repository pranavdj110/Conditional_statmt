using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{

    class Q16StackCol
    {
        static void Main(string[] args)
        {
            Stack<Student> sc = new Stack<Student>();
            sc.Push(new Student(10, "Ricky", 45));
            sc.Push(new Student(12, "Mathew", 67));
            sc.Push(new Student(14, "Andrew", 60));

            foreach (Student s in sc)
                Console.WriteLine(s);
            
         

        }
    }
}
