using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conditional_statmt.Library_mgmt
{
    class Library
    {
        static void Main(String[] args)
        {
            Console.WriteLine("|--------------------WELCOME TO LIBRARY---------------------|");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("|Enter Your Choice(Enter 1 or 2)                            |");
            Console.WriteLine("|                                                           |");
            Console.WriteLine("| 1.Log In(Already Member)                                  |");
            Console.WriteLine("| 2.Register(New Member)                                    |");
            Console.WriteLine("|                                                           |");
            Console.Write("| Your Choice: ");
            int choice = int.Parse(Console.ReadLine());
            // Console.WriteLine("|  Your Entered  " + choice+"                                |");

            switch (choice)
            {
                case 2: Register();
            break;
                case 1:LogIn();
                    break;

            }

             void Register()
            {

                Console.Write("Enter First Name:");
                string fname = Console.ReadLine();

                Console.Write("Enter Last Name:");
                string lname = Console.ReadLine();

                

                Console.Write("Enter Address:");
                string Address = Console.ReadLine();

                Console.Write("Enter Email(Your Email will be Log In ID):");
                string email = Console.ReadLine();

                Console.Write("Enter Password:");
                string passwords = Console.ReadLine();

                string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=Library_mgmt;Integrated Security=true";
                SqlConnection con = new SqlConnection(str);
                con.Open();
               

                
                
                
                SqlCommand cmd = new SqlCommand("insert into Member(fname,lname,email,passwords,Address) values(@fname,@lname,@email,@passwords,@Address)", con);

                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@passwords", passwords);
                cmd.Parameters.AddWithValue("@Address", Address);

                int count = cmd.ExecuteNonQuery();
                Console.WriteLine(count);
                con.Close();

            }
            void LogIn()
            {
                /*Console.Write("Enter Log In ID:");
                string lg = Console.ReadLine();
                Console.Write("Password:");
                string pd = Console.ReadLine();

                string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=HR;Integrated Security=true";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("select password from employees where Email_id=", con);
                */


                if (true)
                {
                    
                    
                    Console.WriteLine("Select Choice:");
                    Console.WriteLine("1.View Books");
                    Console.WriteLine("2.Issue Books");
                    Console.WriteLine("3.Return Books");
                    Console.Write("Enter your Choice(1/2/3):");
                    int choice1 = int.Parse(Console.ReadLine());
                    switch (choice1)
                    {
                        case 1: ViewBooks();
                            break;
                        case 2: IssueBook();
                            break;
                        case 3:ReturnBook();
                            break;

                            void ViewBooks()
                            {

                                string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=Library_mgmt;Integrated Security=true";
                                SqlConnection con = new SqlConnection(str);
                                con.Open();

                                SqlCommand cmd = new SqlCommand("select * from Book",con);


                                SqlDataReader reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {


                                    Console.WriteLine("Book_Id: " + reader[0]+ "  Name:" + reader[1] +"   Author:" + reader[2]+ "   Name:" + reader[3] + "   Available:" + reader[4] );
                                }
                                con.Close();

                            }

                            void IssueBook()
                            {
                                Console.Write("Enter Book you want to take:");
                                string bk_id = Console.ReadLine();
                                string str = "server=DESKTOP-FHD8LTV\\SQLEXPRESS;Database=Library_mgmt;Integrated Security=true";
                                SqlConnection con = new SqlConnection(str);
                                con.Open();

                                SqlCommand cmd = new SqlCommand("Update Book set Available='N' where Book_id=" + "'"+bk_id +"' ", con);
                               // SqlCommand cmd = new SqlCommand("insert into Transactions(Member_id,Booh_id,issue_date,return_date,status) values(101,'B402',10-05-2022,20-05-2022,issued)",con
                                int count = cmd.ExecuteNonQuery();
                                Console.WriteLine(count);



                            }

                            void ReturnBook()
                            {

                               //Upate Transactions set status='Returned' where tans_id=
                            }
                    }

                }


            }


        }
    }
}
