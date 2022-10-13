using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional_statmt.Week4_exam_13Aug
{
    class Engine
    {
        string engineId;
        string last_Engine_clean_date;

        public string EngineId
        {
            get
            {
                return engineId;
            }
            set
            {
                engineId = value;
            }
        }
        public string Last_Engine_Clean_Date
        {
            get
            {
                return last_Engine_clean_date;
            }
            set
            {
                last_Engine_clean_date = value;
            }
        }
    }
    class SubEngine
    {
        string subnEngine_type;
        public string SubEngine_Type
        {
            get
            {
                return subnEngine_type;
            }
            set
            {
                subnEngine_type = value;
            }

        }

    }
    class Gear
    {
        string gear_type;
        public string Gear_Type
        {
            get
            {
                return gear_type;
            }
            set
            {
                gear_type = value;
            }
        }


    }
    class Car
    {
        int carId;
        string carColor;
        Engine en;
        Gear gr;

        public int CarId
        {
            get
            {
                return carId;
            }
            set
            {
                carId = value;
            }
        }
        public string CarColor
        {
            get
            {
                return carColor;
            }
            set
            {
                carColor = value;
            }
        }
        public Engine En
        {
            get
            {
                return en;
            }
            set
            {
                en = value;
            }
        }
        public Gear Gr
        {
            get
            {
                return gr;
            }
            set
            {
                gr = value;
            }
        } 
    }
        class CarInfo
        {
            static void Main(String[] args)
            {
                Car c = new Car();
                c.CarColor = "white";
                c.CarId = 0101;
                c.En = new Engine();
                c.En.EngineId = "901";
                c.En.Last_Engine_Clean_Date = "01042022";
                c.Gr = new Gear();
                c.Gr.Gear_Type = "Manual";
                Console.WriteLine(c.CarColor + " " + c.CarId + " " + c.En.EngineId + " " + c.En.Last_Engine_Clean_Date + " " + c.Gr.Gear_Type);
            }
        }


    
}
