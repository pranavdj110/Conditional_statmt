using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Student
    {
        int roll_no;
        string name;
        int marks;

        public Student(int roll_no, string name, int marks)
        {
            this.roll_no = roll_no;
            this.name = name;
            this.marks = marks;
        }

        public int Roll_no { get => roll_no; set => roll_no = value; }
        public string Name { get => name; set => name = value; }
        public int Marks { get => marks; set => marks = value; }

        public override string ToString()
        {
            // return $"name: { name } rating:{rating} ";
            return $"roll no:{roll_no} Name:{name} Marks:{marks}";
        }
    }
    class Q6Listcol
    {
        static void Main(string[] args)
        {
            List<Student> l1 = new List<Student>();
            l1.Add(new Student(1, "Ram", 100));
            l1.Add(new Student(2, "shyam",80));
            l1.Add(new Student(3, "Raghu",91));

            foreach (Student s in l1)
                Console.WriteLine(s);


        }
    }
}
