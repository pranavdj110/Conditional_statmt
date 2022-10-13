using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Departments
    {
        int dept_id;
        string dept_name;


        public override string ToString()
        {
            return "Deptid:"+dept_id+" DeptName:"+dept_name;
        }
        public Departments(int dept_id, string dept_name)
        {
            this.dept_id = dept_id;
            this.dept_name = dept_name;
        }

        public int Dept_id { get => dept_id; set => dept_id = value; }
        public string Dept_name { get => dept_name; set => dept_name = value; }
    }

    class Emp 
    {
        int eno;
        string enme;
        int salary;
        Departments d;

        public override string ToString()
        {
            return "Empno:" + eno + " Name:" + enme + " Salary:" + salary + " DeptDetails:" + d;

        }
        public Emp(int eno, string enme, int salary, Departments d)
        {
            this.eno = eno;
            this.enme = enme;
            this.salary = salary;
            this.d = d;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Enme { get => enme; set => enme = value; }
        public int Salary { get => salary; set => salary = value; }
        internal Departments D { get => d; set => d = value; }
    }

    class Q17LinkedListCol
    {
        static void Main(string[] args)
        {
            LinkedList<Emp> Lk = new LinkedList<Emp>();
            Lk.AddFirst(new Emp(1, "Raj", 3000, new Departments(1, "IT")));
            Lk.AddLast(new Emp(2, "Ram", 3000, new Departments(2, "Sales")));

            Lk.AddLast(new Emp(3, "Om", 4000, new Departments(3, "Marketing")));
            Lk.AddLast(new Emp(4, "Rohit", 3000, new Departments(2, "Sales")));
            Lk.AddLast(new Emp(5, "virat", 5000, new Departments(1, "IT")));

            int eno = 2;
            string dept_name = "";
            foreach (Emp e in Lk)
            {
                if (e.Eno == 2)
                {
                    dept_name = e.D.Dept_name; 
                }
            }
            Emp[] earr = new Emp[Lk.Count];
                Lk.CopyTo(earr, 0);
            for (int i = 0; i < Lk.Count; i++)
            {
                if (earr[i].D.Dept_name == dept_name)
                {
                    Lk.Remove(earr[i]);
                }


            }

            foreach(Emp e in Lk)
                Console.WriteLine(e);
                
        }
    }
}
