using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week_9_Exam
{
    class Employee:IComparable<Employee>
    {
        string name;
        string designation;
        int age;
        
        public Employee(string name, string designation, int age)
        {
            this.name = name;
            this.designation = designation;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"Name:{name} Designtion:{designation} Age:{age}";
        }

        public int CompareTo(Employee e)
        {
            return e.age.CompareTo(this.age);
        }


    }
    class Q10ListCol
    {
        static void Main(string[] args)
        {
            List<Employee> e = new List<Employee>();
            e.Add(new Employee("Ravi", "Coach", 65));
            e.Add(new Employee("David", "Manager", 56));
            e.Add(new Employee("Shrinath", "Assistant", 61));
            e.Add(new Employee("Ajit", "Developer", 41));
            e.Sort();
            foreach (Employee e1 in e)
                Console.WriteLine(e1);


        }
    }
}
