using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace HotelConsole_Application
{
    class Program
    {
        static void Main(string[] args)

        {
            String connectionstring = "Server= .             ; Database= hotel        ;trusted_connection=true  ";
            using (SqlConnection con = new SqlConnection(connectionstring))
            {                                           
                //con.ConnectionString=connectionstring;
                con.Open();
                Console.WriteLine("Enter name_customer");
                String x = Console.ReadLine();
                String query = "Select * from Coustomer where name_customer='" +  x +"' and id_customer=1";
                SqlCommand cmd = new SqlCommand(query , con);
               // cmd.Connection = con;
               // cmd.CommandText = "Select * from Coustomer";


                SqlDataReader rd = cmd.ExecuteReader() ;

                //   while (rd.Read())
              //  {

                 
              //  Console.WriteLine(rd.GetValue(0) + " " + rd.GetString(1) + "    " + rd.GetString(2) + "  ");

               // }

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                       
                 Console.WriteLine(rd["id_customer"] + " " + rd["name_customer"] + "    " + rd["phone_number"] + "  "+ rd["countre"] +" "+ rd["proof_id"]  + "  ");
                         

                    }
                }
                else {
                    Console.WriteLine("There are no Data");
                }
             
            }

           // con.Close();

            Console.ReadLine();
            
        }
    }
}
