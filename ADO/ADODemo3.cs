using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conditional_statmt.ADO
{
    class ADODemo3
    {
        static void Main(string[] args)
        {
            string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=HR;Integrated Security=true";
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from employees e inner join departments d on e.department_id=d.department_id", con);
            SqlDataReader reader = cmd.ExecuteReader();
            bool b = reader.HasRows;     
            Console.WriteLine(b);

            int n = reader.FieldCount;     
            Console.WriteLine(n);

            for (int i = 1; i < n; i++)
            {
                string s = reader.GetDataTypeName(i);
                string cname = reader.GetName(i);
                Console.WriteLine(cname + "   " + s);
            }

            while (reader.Read())
            {


                Console.WriteLine("Name:" + reader[1] + "   " + "Email:" + reader[3]);

                
            }
            con.Close();
        }
    }
}
