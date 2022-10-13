using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Conditional_statmt.ADO
{
    class ADODemo1
    {
        static void Main(String[] args)
        {
            string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=HR;Integrated Security=true";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            int n = 101;
            // SqlCommand cmd = new SqlCommand("select * from employees",con);
            SqlCommand cmd = new SqlCommand("select * from employees where employee_id=" + n+" ", con);
 
             
            SqlDataReader reader=cmd.ExecuteReader();

            while (reader.Read())
           {


               Console.WriteLine("Name:" + reader[1]);
           }



          /*  bool b = reader.HasRows;     //whether table contains any record or not.
            Console.WriteLine(b);

            int n = reader.FieldCount;     //fieldcount=number of columns;
            Console.WriteLine(n);

            ////string s = reader.GetDataTypeName(1);                  //returns data type of particular column.
            //Console.WriteLine(s);
            for (int i = 1; i < n; i++)
            {
                string s = reader.GetDataTypeName(i);
                Console.WriteLine(s);
            }

            string cname = reader.GetName(1);                //returns column name.
            Console.WriteLine(cname);

            for (int i = 0; i < n; i++)
            {
                string s = reader.GetDataTypeName(i);
                string cname1 = reader.GetName(i);
                Console.WriteLine(cname1 + "   " + s);
            }*/

            /*bool b1 = reader.IsDBNull(4);
            Console.WriteLine(b1);*/
        }
    }
}
