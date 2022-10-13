using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.OOPs
{
    class Student
    {
        string name;
        int marathi;
        int science;
        int maths;
        int total;
        double percentage;
        public Student(string name,int marathi,int science,int maths)
        {
            this.name = name;                   //USE1:to avoid shadowing(instance variable and local variavle having same name)
            this.marathi = marathi;
            this.science = science;
            this.maths = maths;
        }

        public Student():this("Raju",86,92,90)     //USE3: to call a constructor from another constructor
        {
            total = marathi + science + maths;
            percentage = total/3;
            this.Display();                    //USE2:to call current instance method.
        }

        public void Display()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Marks_Marathi:" + marathi);
            Console.WriteLine("Marks_Science:" + science);
            Console.WriteLine("Marks_Maths:" + maths);
            Console.WriteLine("Total Marks:" + total+"/300");
            Console.WriteLine("Percentage:" + percentage);

        }


        static void Main(String[] args)
        {
            Student s1 = new Student();
        }
    }
}
