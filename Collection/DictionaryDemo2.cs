using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class Student
    {
        int roll_no;
        string name;
        public override int GetHashCode()
        {
           
                return HashCode.Combine(roll_no, name);
            
        }

        public override bool Equals(object obj)
        {
            Student s1 = (Student)obj;
            return this.roll_no == s1.roll_no && this.name == s1.name;
        }

        public Student(int roll_no, string name)
        {
            this.roll_no = roll_no;
            this.name = name;
            
        }

        public int Roll_no { get => roll_no; set => roll_no = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return $"Roll no:{roll_no} Name:{name}";
        }

    }
    class DictionaryDemo2
    {
        static void Main(string[] args)
        {
            Dictionary<Student, int> dt = new Dictionary<Student, int>();
            dt.Add(new Student(1, "Ram"), 100);
            dt.Add(new Student(1, "Ram"), 100);
            dt.Add(new Student(1, "Ram"), 100);

            foreach (KeyValuePair<Student, int> kv in dt)
                Console.WriteLine(kv.Key + " " + kv.Value);

        }
       
        
    }
}
