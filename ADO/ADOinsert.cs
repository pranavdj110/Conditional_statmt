using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace Conditional_statmt.ADO
{
    class DBConnect
    {
        const string cs= "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=Library_mgmt;Integrated Security=true";
        public static SqlConnection GetConnection()
        {
            //try
            {
                SqlConnection con = new SqlConnection(cs);
                return con;
            }
            /*catch(Exception e)
            {
                Console.WriteLine(e.Message());
            }
            return null;*/
        }
    }
    class ADOinsert
    {
        static void Main(string[] args)
        {
            SqlConnection con = DBConnect.GetConnection();
            con.Open();
            Console.WriteLine("Enter book id");
            int bk_id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter book name:");
            string bk_name = Console.ReadLine();

            Console.WriteLine("Enter Book price:");
            int bk_price = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter book No of copies");
            int bk_cp = int.Parse(Console.ReadLine());

            SqlCommand cmd = new SqlCommand("insert into Book values(@i,@bknm,@pr,@cp)",con);

            cmd.Parameters.AddWithValue("@i", bk_id);
            cmd.Parameters.AddWithValue("@bknm", bk_name);
            cmd.Parameters.AddWithValue("@pr", bk_price);
            cmd.Parameters.AddWithValue("@cp", bk_cp);

            int count = cmd.ExecuteNonQuery();
            Console.WriteLine(count);

        }
    }
}
