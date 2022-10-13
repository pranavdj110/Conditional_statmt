using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Collection
{
    class Employee1
    {
        string name;
        string department;
        /*public int CompatrTo(Employee1 e)
        {
            return 1;
        }
        */

        public Employee1(string name, string department)
        {
            this.name = name;
            this.department = department;
        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
    }
    class SortedListDemo2
    {
        static void Main(string[] args)
        {
            SortedList<Employee1, int> ss = new SortedList<Employee1, int>();
            ss.Add(new Employee1("Ravi", "Sales"), 50000);
            ss.Add(new Employee1("Saurabh", "IT"), 70000);
            ss.Add(new Employee1("Ramu", "Marketing"), 40000);
            ss.Add(new Employee1("Shyam", "Sales"), 56000);

            foreach (KeyValuePair<Employee1, int> kv in ss)
                Console.WriteLine(kv.Key + " " + kv.Value);

        }
    }
}
