using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{

    class Students
    {
        int roll_no;
        string name;
        public override int GetHashCode()
        {

            return HashCode.Combine(roll_no, name);

        }

        public override bool Equals(object obj)
        {
            Students s1 = (Students)obj;
            return this.roll_no == s1.roll_no && this.name == s1.name;
        }

        public Students(int roll_no, string name)
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
    class Q14DictColl
    {
        static void Main(string[] args)
        {
            Dictionary<Students, int> dt = new Dictionary<Students, int>();
            dt.Add(new Students(1, "Ram"), 100);
            dt.Add(new Students(3, "Shyaam"), 102);
            dt.Add(new Students(4, "Raj"), 104);

            foreach (KeyValuePair<Students, int> kv in dt)
                Console.WriteLine(kv.Key + " " + kv.Value);

        }


    }
}
