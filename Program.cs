using System;
using System.Data.SqlClient;

namespace HW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SqlConnectionStringBuilder connect =
                new SqlConnectionStringBuilder();
            connect.InitialCatalog = "Autolot";
            connect.DataSource = @"(local)\SQLEXPRESS";
            connect.ConnectTimeout = 30;
            connect.IntegratedSecurity = true;

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                cn.Open();
                cn.Close();
            }
        }
    }
}
