using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.OOPs
{
    class Vehicle
    {
        string model_num;
        string type_of_vehicle;
        int num_of_wheels;
        double average;

        public void AcceptDetails(string vmodel_num, string vtype_of_vehicle, int vnum_of_wheels)
        {
            model_num = vmodel_num;
            type_of_vehicle = vtype_of_vehicle;
            num_of_wheels = vnum_of_wheels;
        }
        
        public void calaverage()
        {
            int value;
            if(type_of_vehicle=="truck")
            {
                value = 80;
                average = value / num_of_wheels;
            }
           else if (type_of_vehicle == "car")
            {
                value = 60;
                average = value / num_of_wheels;
            }
            else if (type_of_vehicle == "bike")
            {
                value = 100;
                average = value / num_of_wheels;
            }
            else
            {
                value = 50;
                average = value / num_of_wheels;
            }
           
        }

        public void Display()
        {
            Console.WriteLine(model_num);
            Console.WriteLine(type_of_vehicle);
            Console.WriteLine(num_of_wheels);
            Console.WriteLine(average);

        }

        static void Main(String[] args)
        {
            Vehicle v1 = new Vehicle();
            v1.AcceptDetails("VN001", "truck", 8);
            v1.calaverage();
            v1.Display();
        }
    }
 }

