using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Has_a_relation_containment
{
    class Department
    {
        int dept_id;
        string dept_name;

       public Department(int dept_id,string dept_name)
        {
            this.dept_id = dept_id;
            this.dept_name = dept_name;
        }

        public void DisplayDepartment()
        {
            Console.WriteLine(dept_id + " " + dept_name);
        }
    }
    class Employee
    {
        int id;
        string name;
        int salary;
        Department dept;
       public Employee(int id,string name,int salary, Department dept)
        {
            this.id = id;
            this.name=name;
            this.salary=salary;
            this.dept = dept;

        }
        public void DisplayEmployee()
        {
            Console.WriteLine(id + " " + name + " " + salary);
            dept.DisplayDepartment();
            
        }
        static void Main(String[] args)
        {
            Department d1 = new Department(1, "Computer");
            Employee e1 = new Employee(21, "Ram",21000, d1);
            e1.DisplayEmployee();

        }
    }
}
